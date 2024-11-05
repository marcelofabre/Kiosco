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
            #region Carga de combos
            await Task.WhenAll(
                Task.Run(async () => comboProveedor.DataSource = await proveedorService.GetAllAsync()),
                Task.Run(async () => comboProveedor.DataSource = await productoService.GetAllAsync())
                );

            comboProveedor.DisplayMember = "Nombre";
            comboProveedor.ValueMember = "Id";

            comboProveedor.DisplayMember = "Nombre";
            comboProveedor.ValueMember = "Id";
            comboProveedor.SelectedIndex = -1;

            comboFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            #endregion

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            dataGridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleCompra = new Detallescompra
            {
                Producto = (Producto)comboProductos.SelectedItem,
                ProductoId = (int)comboProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value

            };
            compra.DetalleCompras.Add(detalleCompra);
            dataGridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
            comboProductos.SelectedIndex = -1;
            comboProductos.Focus();
            ActualizarTotalFactura();
        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = compra.DetalleCompras.Sum(detallecompras => detallecompras.Subtotal);
        }

        private void gridDetallesCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridDetallesCompra.OcultarColumnas(new string[] { "Id", "CompraId", "ProductoId", "Eliminado", "Compra" });
            btnQuitar.Enabled = dataGridDetallesCompra.RowCount > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridDetallesCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de compra");
                return;
            }
            var detalleCompra = (Detallescompra)dataGridDetallesCompra.CurrentRow.DataBoundItem;
            compra.DetalleCompras.Remove(detalleCompra);
            dataGridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
            ActualizarTotalFactura();
        }

        private void numericSubtotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericCantidad_ValueChanged_1(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void comboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboProductos.SelectedIndex != -1;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void comboProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var detalleCompra = new Detallescompra
            {
                Producto = (Producto)comboProductos.SelectedItem,
                ProductoId = (int)comboProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value

            };
            compra.DetalleCompras.Add(detalleCompra);
            dataGridDetallesCompra.DataSource = compra.DetalleCompras.ToList();
            comboProductos.SelectedIndex = -1;
            comboProductos.Focus();
            ActualizarTotalFactura();
        }
    }
}
