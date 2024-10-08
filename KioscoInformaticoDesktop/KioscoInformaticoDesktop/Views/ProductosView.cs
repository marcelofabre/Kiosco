﻿using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource listaproductos = new BindingSource();
        List<Producto> ListaAFiltrar = new List<Producto>();
        Producto productoCurrent;

        public ProductosView()
        {
            InitializeComponent();
            DataGridProductos.DataSource = listaproductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            {
                listaproductos.DataSource = await productoService.GetAllAsync();
                ListaAFiltrar = (List<Producto>)listaproductos.DataSource;



                //ocultamos las columnas de detalle ventas y detalles compras
                DataGridProductos.Columns[3].Visible = false;
                DataGridProductos.Columns[4].Visible = false;
                //le sacamos los numeros con coma a los IDs
                DataGridProductos.Columns["Id"].DefaultCellStyle.Format = "N0";

                

            }
        }







        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                MessageBox.Show("Debe ingresar un nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                productoCurrent.Precio = numericPrecio.Value;
                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;

            }
            else
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = numericPrecio.Value
                };

                await productoService.AddAsync(producto);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            numericPrecio.Value = 0;
            tabControl.SelectTab(tabLista);
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)listaproductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            numericPrecio.Value = productoCurrent.Precio;


            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var producto = (Producto)listaproductos.Current;
                await productoService.DeleteAsync(producto.Id);
                CargarGrilla();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabLista);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            var productosFiltrados = ListaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();
            listaproductos.DataSource = productosFiltrados;



        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }
    }
}

