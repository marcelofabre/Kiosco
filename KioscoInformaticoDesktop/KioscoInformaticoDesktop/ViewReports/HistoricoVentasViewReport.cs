using KioscoInformaticoServices.Models;
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
    public partial class HistoricoVentasViewReport : Form
    {
        ReportViewer reporte;
        private List<Venta> ListaVenta;
        private string tituloReporte;
        public HistoricoVentasViewReport(List<Venta> ventas, string tituloReporte)
        {

            InitializeComponent();
            ListaVenta = ventas;
            this.tituloReporte = tituloReporte;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
            
        }

        private void HistoricoVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.HistoricoVentasReport.rdlc";

            //armamos la lista de ventas para el reporte
          
            
                var ventas= ListaVenta.
                OrderBy(venta=>venta.FormaPago).
                Select(venta => new{ Id = venta.Id, Fecha = 
                    venta.Fecha, ClienteNombre = venta.Cliente.Nombre,FormaPago = 
                    venta.FormaPago.ToString(), Total = venta.Total, Iva = venta.Iva }).ToList();

            
                reporte.LocalReport.SetParameters(new ReportParameter("TituloReporte", tituloReporte)); 
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                //definimos zoom al 100%
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;
                reporte.RefreshReport();
            }
        }
    }

