using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ComprasView : Form
    {
        ProductoService productoService = new ProductoService();
        IGenericService<Compra> compraService = new GenericService<Compra>();
        IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        Compra compra = new Compra();

        public ComprasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            #region carga de combos
            //Stopwatch reloj = new Stopwatch();
            //reloj.Start();

            await Task.WhenAll(

                Task.Run(async () => cboProveedores.DataSource = await proveedorService.GetAllAsync()),
                Task.Run(async () => cboProductos.DataSource = await productoService.GetAllAsync())
                );


            cboFormaPago.DisplayMember = "Nombre";
            cboFormaPago.ValueMember = "Id";



            cboProductos.DisplayMember = "Nombre";
            cboProductos.ValueMember = "Id";
            cboProductos.SelectedIndex = -1;

            cboProveedores.DisplayMember = "Nombre";
            cboProveedores.ValueMember = "Id";
            cboProveedores.SelectedIndex = -1;

            //reloj.Stop();
            //Debug.Print($"tiempo de carga de combos:{reloj.ElapsedMilliseconds}ms");

            cboFormaPago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            #endregion
            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetallesCompra.DataSource = compra.DetalleCompras.ToList();

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)cboProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = cboProductos.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleCompra = new Detallescompra
            {
                Producto = (Producto)cboProductos.SelectedItem,
                ProductoId = (int)cboProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            compra.DetalleCompras.Add(detalleCompra);
            gridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
            cboProductos.SelectedIndex = -1;
            cboProductos.Focus();
            ActualizarTotalFactura();
        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = compra.DetalleCompras.Sum(dc => dc.Subtotal);
        }

        private void gridDetallesCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetallesCompra.OcultarColumnas(new string[] { "Id", "CompraId", "ProductoId", "Eliminado", "Compra","ProductoId", "ProductosId" });
            btnQuitar.Enabled = gridDetallesCompra.RowCount > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetallesCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de compra");
                return;
            }
            var detalleCompra = (Detallescompra)gridDetallesCompra.CurrentRow.DataBoundItem;
            compra.DetalleCompras.Remove(detalleCompra);
            gridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
            ActualizarTotalFactura();
        }

        private async void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            compra.ProveedorId = (int)cboProveedores.SelectedValue;
            compra.Proveedor = (Proveedor)cboProveedores.SelectedItem;
            compra.FormaDePago = (FormaDePagoEnum)cboFormaPago.SelectedValue;
            compra.Fecha = DateTime.Now;

            compra.Total = numericTotal.Value;
            compra.Iva = compra.Total * 0.21m;
            var nuevaCompra = await compraService.AddAsync(compra);
            var facturaCompraViewReport = new FacturaCompraViewReport(nuevaCompra);
            facturaCompraViewReport.ShowDialog();
        }
    }
}
