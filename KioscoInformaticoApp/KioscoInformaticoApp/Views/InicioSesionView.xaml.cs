using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class InicioSesionView : ContentPage
{
	public InicioSesionView()
	{
		InitializeComponent();
        //BindingContext = new InicioSesionViewModel();
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProducto")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            await Navigation.PushAsync(new ProductosEnOfertaView());
        }

        if (mensaje.Value == "AgregarProducto")
        {
            await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
        }

        if (mensaje.Value == "EditarProducto")
        {
            await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
        }


        if (mensaje.Value == "CerrarVentana")
        {
            await Navigation.PopAsync();
        }


    }
}