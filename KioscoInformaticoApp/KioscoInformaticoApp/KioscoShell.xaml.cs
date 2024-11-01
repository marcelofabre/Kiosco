using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }
    }


    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProducto")
        {
            //await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            //await Navigation.PushAsync(new ProductosEnOfertaView());
        }

        if (mensaje.Value == "AgregarProducto")
        {
            //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
        }

        if (mensaje.Value == "EditarProducto")
        {
            //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
        }

   

    }
}
