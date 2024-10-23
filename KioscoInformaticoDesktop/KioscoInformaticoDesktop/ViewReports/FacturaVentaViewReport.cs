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
    public partial class FacturaVentaViewReport : Form
    {
        ReportViewer reporte;
        private Venta? nuevaVenta;

        public FacturaVentaViewReport()
        {

            this.nuevaVenta = nuevaVenta;
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public FacturaVentaViewReport(Venta? nuevaVenta)
        {
            this.nuevaVenta = nuevaVenta;
        }

        private void FacturaVentaViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";

           var venta= new { Id = nuevaVenta.Id, Fecha = nuevaVenta.Fecha, Cliente = nuevaVenta.Cliente.Nombre, FormaDePago = nuevaVenta.FormaPago, Total = nuevaVenta.Total };

            var detalleVenta= nuevaVenta.DetallesVenta.Select(nuevaVenta => new { Producto = nuevaVenta.Producto.Nombre, Cantidad = nuevaVenta.Cantidad, Precio = nuevaVenta.PrecioUnitario, Subtotal = nuevaVenta.SubTotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVenta", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetalllesVenta", detalleVenta));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();

        }
    }
}
