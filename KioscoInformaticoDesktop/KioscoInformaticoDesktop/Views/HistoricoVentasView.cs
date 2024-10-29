using KioscoInformaticoDesktop.ExtensionMethods;
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
    public partial class HistoricoVentasView : Form
    {
        GenericService<Venta> _ventaService = new GenericService<Venta>();
        List<Venta> ventas = new List<Venta>();
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();

        }


        private async void LoadData()
        {
            ventas = await _ventaService.GetAllAsync();
            DisplayDataDrid();
            CalculeTotal();
        }

        private void CalculeTotal()
        {
            if(checkFiltrado.Checked){ 
                numericTotalFacturado.Value = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                     venta.Fecha <= dateTimeHasta.Value).Sum(venta => venta.Total);

            }
            else
            {
                numericTotalFacturado.Value = ventas.Sum(venta => venta.Total);
            }
          

        }

        private async void DisplayDataDrid()
        {
            
            dataGridVentas.DataSource = ventas;
            dataGridVentas.OcultarColumnas(new string[] { "id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void checkFiltrado_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Enabled = checkFiltrado.Checked;

            if (checkFiltrado.Checked)
            {
                dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimeDesde.Value = DateTime.Now;
                DisplayDataGridFilter();
                CalculeTotal();
            }

            else
            {
                DisplayDataDrid();
                CalculeTotal();
            }
        }

        private void DisplayDataGridFilter()
        {
           
            dataGridVentas.DataSource = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                     venta.Fecha <= dateTimeHasta.Value).ToList();


            dataGridVentas.OcultarColumnas(new string[] { "id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DisplayDataGridFilter();
            CalculeTotal();
        }
    }
}
