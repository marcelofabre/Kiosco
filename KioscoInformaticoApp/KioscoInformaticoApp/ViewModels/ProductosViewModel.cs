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
        private GenericService<Producto> ProductoService= new GenericService<Producto>();
        private string filterProducts;

        public string FilterProducts
        {
            get { return filterProducts; }
            set
            {
                filterProducts = value;

                OnPropertyChanged();
                // FilterProductsCollection();
                FiltrarProductos(); 

            }
        }

        private ObservableCollection<Producto> productos;

        public ObservableCollection<Producto> Productos
        {
            get { return productos; }
            set
            {
                productos = value;

                OnPropertyChanged();
            }
        }

        private List<Producto> productosListToFilter;
        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductoCommand { get; }

        private bool activityStart;

        public bool ActivityStart
        {
            get { return activityStart; }
            set { activityStart = value;
                OnPropertyChanged();

            }
        }



        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductoCommand = new Command(async () => await FiltrarProductos());
            ObtenerProductos();
        }

        public async Task FiltrarProductos()
        {
            var productoFiltrado= productosListToFilter.Where(p => p.Nombre.ToUpper().Contains(FilterProducts));
            Productos = new ObservableCollection<Producto>(productosListToFilter.Where(x => x.Nombre.ToUpper().Contains(FilterProducts.ToLower())));
            


        }

        private async Task ObtenerProductos()
        {
            filterProducts = string.Empty;
            ActivityStart = true;
            productosListToFilter = await ProductoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            ActivityStart = false;
        }
    }

}
