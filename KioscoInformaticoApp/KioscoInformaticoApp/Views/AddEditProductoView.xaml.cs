using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AddEditProductoView : ContentPage
{
	public AddEditProductoView()
	{
		InitializeComponent();
	}
    public AddEditProductoView(Producto producto)
    {
        InitializeComponent();
        var view = this.BindingContext as ViewModels.AddEditProductoViewModel;
        view.EditProduct = producto;

    }
}