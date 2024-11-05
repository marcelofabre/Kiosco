using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoDesktop.Views;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void ItemMEnuSalirDelSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemMenuLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.Show();
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.Show();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.Show();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.Show();
        }

        private void iconMenuLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesViewReport localidadesViewReport = new LocalidadesViewReport();
            localidadesViewReport.Show();

        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            ClientesViewReport clientesViewReport = new ClientesViewReport();
            clientesViewReport.Show();
        }



        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            VentasView ventasView = new VentasView();
            ventasView.Show();
        }

        private void iconMenuVentas_Click(object sender, EventArgs e)
        {
            HistoricoVentasView historicoVentasView = new HistoricoVentasView();
            historicoVentasView.Show();

        }

        private void Compra_Click(object sender, EventArgs e)
        {
            ComprasView comprasView = new ComprasView();
            comprasView.Show();
        }
    }
}
