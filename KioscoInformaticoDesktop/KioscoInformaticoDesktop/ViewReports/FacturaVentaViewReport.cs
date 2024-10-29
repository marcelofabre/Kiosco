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

       

        public FacturaVentaViewReport(Venta? nuevaVenta)
        {

            this.nuevaVenta = nuevaVenta;
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FacturaVentaViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";

            List<object> venta=new List<object>{ new { Id = nuevaVenta.Id, Fecha = nuevaVenta.Fecha, ClienteNombre = nuevaVenta.Cliente.Nombre, FormaPago = nuevaVenta.FormaPago.ToString(), Total = nuevaVenta.Total } };
            //.ToShortDateString() para hacer corta la fecha

            var detalleVenta = nuevaVenta.DetallesVenta.Select(nuevaVenta => new { ProductoNombre = nuevaVenta.Producto.Nombre, Cantidad = nuevaVenta.Cantidad, PrecioUnitario = nuevaVenta.PrecioUnitario, SubTotal = nuevaVenta.SubTotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detalleVenta));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
            

        }
    }
}
