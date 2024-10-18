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
        
 

        public Command GetProductsCommand { get; }
		public Command FilterProductsCommand { get; }
        public Command AddProducCommand { get; }

        public ProductosViewModel()
        {
            GetProductsCommand = new Command(async () => await GetProducts());
            FilterProductsCommand = new Command(async () => await FiltrarProductos());
            AddProducCommand = new Command(async () => await AddProductos());
            GetProducts();
        }

        private async Task AddProductos()
        {
            WeakReferenceMessenger.Default.Send(new Message("AgregarProducto"));
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
