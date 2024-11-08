using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

[QueryProperty(nameof(Product),"ProductoToEdit")]
public partial class AddEditProductoView : ContentPage
{

    public Producto Product
    {
        set
        {
            var producto = value;
            var viewmodel = this.BindingContext as AddEditProductoViewModel;
            viewmodel.EditProduct = producto;
        }
    }
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