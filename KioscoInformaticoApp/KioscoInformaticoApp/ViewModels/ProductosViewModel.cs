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
		private GenericService<Producto> productService= new GenericService<Producto>();
        private string filterProducts;

		public string FilterProducts
		{
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                FiltrarProductos();
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

        private ObservableCollection<Producto> products;

		public ObservableCollection<Producto> Products
		{
			get { return products; }
			set { products = value;
			OnPropertyChanged();
            }
		}

        private List<Producto>? productListToFilter;

        private bool activityStart;

        public bool ActivityStart
        {
            get { return activityStart; }
            set { activityStart = value; 
                OnPropertyChanged();
            }
        }


        public Command GetProductsCommand { get; }
		public Command FilterProductsCommand { get; }

        public ProductosViewModel()
        {
            GetProductsCommand = new Command(async () => await GetProducts());
            FilterProductsCommand = new Command(async () => await FiltrarProductos());
            GetProducts();
        }

        private async Task FiltrarProductos()
        {
            var productsLeaked = productListToFilter.Where(p => p.Nombre.ToLower().Contains(filterProducts.ToLower())).ToList();
            Products = new ObservableCollection<Producto>(productsLeaked);
        }   

        private async Task GetProducts()
        {
            FilterProducts = string.Empty;
            ActivityStart = true;
            productListToFilter = await productService.GetAllAsync();
            Products = new ObservableCollection<Producto>(productListToFilter);
            ActivityStart = false;
        }
    }
}
