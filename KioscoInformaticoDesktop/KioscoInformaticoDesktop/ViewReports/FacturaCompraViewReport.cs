using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class FacturaCompraViewReport : Form
    {
        ReportViewer reporte;
        private Compra? nuevaCompra;



        public FacturaCompraViewReport(Compra? nuevaCompra)
        {

            this.nuevaCompra = nuevaCompra;
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FacturaCompraViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaCompraReport.rdlc";

            List<object> Compra = new List<object> { new { Id = nuevaCompra.Id, Fecha = nuevaCompra.Fecha, ProveedorNombre = nuevaCompra.Proveedor.Nombre, FormaPago = nuevaCompra.FormaDePago.ToString(), Total = nuevaCompra.Total } };
            //.ToShortDateString() para hacer corta la fecha

            //var detalleCompra = nuevaCompra.DetallesCompra.Select(nuevaCompra => new { ProductoNombre = nuevaCompra.Producto.Nombre, Cantidad = nuevaCompra.Cantidad, PrecioUnitario = nuevaCompra.PrecioUnitario, SubTotal = nuevaCompra.SubTotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompras", Compra));
            //reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesCompra", detalleCompra));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();


        }
    }
}
