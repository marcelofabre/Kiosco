using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AddEditProductoView : ContentPage
{
    //Constructor para agregar un producto
    public AddEditProductoView()
	{
		InitializeComponent();
	}

    //Constructor para editar un producto
    public AddEditProductoView(Producto producto)
    {
        
        InitializeComponent();
        //Se asigna el producto a la vista
        var view = this.BindingContext as ViewModels.AddEditProductoViewModel;
        view.EditProduct = producto;

    }
}