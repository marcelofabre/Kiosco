using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class ProductosEnOfertaView : ContentPage
{
	public ProductosEnOfertaView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ProductosViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.GetProducts();
        //}
    }
}