using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
        private ProductoService productService = new ProductoService();
        private string filterProducts;
        public string FilterProducts
		{
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                FiltrarProductos();
            }
		}

        private ObservableCollection<Producto> products;

        public ObservableCollection<Producto> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        

        private List<Producto>? ProductListToFilter;

        private Producto selectedProduct;

        public Producto SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged();
                EditProducCommand.ChangeCanExecute();
            }
        }
       



        public Command GetProductsCommand { get; }
		public Command FilterProductsCommand { get; }
        public Command AddProducCommand { get; }
        public Command EditProducCommand { get; }

        public ProductosViewModel()
        {
            GetProductsCommand = new Command(async () => await GetProducts());
            FilterProductsCommand = new Command(async () => await FiltrarProductos());
            AddProducCommand = new Command(async () => await AddProductos());
            EditProducCommand = new Command(async (obj) => await EditarProducto(),PermitirEditar);
            GetProducts();
        }

        private bool PermitirEditar(object arg)

        {
            return SelectedProduct != null;
        }

        private async Task EditarProducto()
        {
           var navigationParameter= new ShellNavigationQueryParameters
           {
                { "ProductoAEditar", SelectedProduct } 
           };

            await Shell.Current.GoToAsync($"//AgregarEditarProducto", navigationParameter);

            //var productoAEditar = ProductListToFilter?.FirstOrDefault(p => p.Id == selectedProduct);
            //if (productoAEditar != null)
            //{
            //    WeakReferenceMessenger.Default.Send(new Message("EditarProducto") { ProductoAEditar = productoAEditar });
            //}
            //await Task.CompletedTask;
        }

        private async Task AddProductos()
        {
            var navigationParameter = new ShellNavigationQueryParameters
           {
                { "ProductoAEditar", null }
           };

            await Shell.Current.GoToAsync($"//AgregarEditarProducto", navigationParameter);
        }
        

        private async Task FiltrarProductos()
        {
            var productsLeaked =  ProductListToFilter.Where(p => p.Nombre.ToLower().Contains(filterProducts.ToLower()));
            Products = new ObservableCollection<Producto>(productsLeaked);
        }   

        public async Task GetProducts()
        {
            FilterProducts = string.Empty;
            IsRefreshing = true;//para que se muestre el refresh
            ProductListToFilter = await productService.GetAllAsync();//obtiene todos los productos
            Products = new ObservableCollection<Producto>(ProductListToFilter);//los muestra en la lista
            IsRefreshing = false;//para que se detenga el refresh
        }
    }
}
