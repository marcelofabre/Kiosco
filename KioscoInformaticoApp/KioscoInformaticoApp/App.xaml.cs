using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.Views;

namespace KioscoInformaticoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new InicioSesionView());
            //MainPage= new ProductosEnOfertaView();
            /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje

        }


    }
}


