using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{

    public partial class ProveedoresView : Form
    {
        IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        ILocalidadService localidadService = new LocalidadService();

        BindingSource listaProveedores = new BindingSource();
        List<Proveedor> listaAFiltrar = new List<Proveedor>();

        Proveedor proveedorCurrent;
        public ProveedoresView()
        {
            InitializeComponent();
            DataGridProveedores.DataSource = listaProveedores;
            CargarGrilla();
            CargarCombo();
            comboCondicionIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
        }

        private async Task CargarGrilla()
        {
            listaProveedores.DataSource = await proveedorService.GetAllAsync();
            listaAFiltrar = (List<Proveedor>)listaProveedores.DataSource;
        }

        //para comboCondicionIva Responsable Inscripto", "Monotributista", "Exento",
        private async Task CargarCombo()
        {
            comboLocalidades.DataSource = await localidadService.GetAllAsync();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";

            comboCondicionIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
            comboCondicionIva.DisplayMember = "Descripcion";
            comboCondicionIva.ValueMember = "Id";

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)listaProveedores.Current;
            if (proveedorCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor {proveedorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                proveedorCurrent = (Proveedor)listaProveedores.Current;
                if (proveedorCurrent != null)
                {
                    await proveedorService.DeleteAsync(proveedorCurrent.Id);
                    await CargarGrilla();
                }
                proveedorCurrent = null;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void FiltrarProveedores()
        {
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                listaProveedores.DataSource = listaAFiltrar;
            }
            else
            {
                listaProveedores.DataSource = listaAFiltrar.Where(x => x.Nombre.ToLower().Contains(txtFiltro.Text.ToLower())).ToList();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (proveedorCurrent != null)
            {
                proveedorCurrent.Nombre = txtNombre.Text;
                proveedorCurrent.Direccion = txtDireccion.Text;
                proveedorCurrent.Telefonos = txtTelefonos.Text;
                proveedorCurrent.Cbu = txtCbu.Text;
                proveedorCurrent.CondicionIva = (CondicionIvaEnum)comboCondicionIva.SelectedValue;
                //proveedorCurrent.LocalidadId = (int?)comboLocalidades.SelectedValue;
                await proveedorService.UpdateAsync(proveedorCurrent);
                proveedorCurrent = null;
            }
            else
            {
                var proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefonos.Text,
                    Cbu = txtCbu.Text,
                    CondicionIva = (CondicionIvaEnum)comboCondicionIva.SelectedValue,
                    LocalidadId = (int?)comboLocalidades.SelectedValue
                };
                await proveedorService.AddAsync(proveedor);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCbu.Text = string.Empty;
            comboCondicionIva.SelectedIndex = -1;
            //comboLocalidades.SelectedIndex = -1;
            tabControl.SelectTab(tabLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)listaProveedores.Current;
            txtNombre.Text = proveedorCurrent.Nombre;
            txtCbu.Text = proveedorCurrent.Cbu;
            txtDireccion.Text = proveedorCurrent.Direccion;
            txtTelefonos.Text = proveedorCurrent.Telefonos;
            //comboLocalidades.SelectedValue = proveedorCurrent.LocalidadId;
            tabControl.SelectedTab = tabPageAgregarEditar;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCbu.Text = string.Empty;
            comboCondicionIva.SelectedIndex = -1;
            //comboLocalidades.SelectedIndex = -1;
            tabControl.SelectTab(tabLista);
        }
    }


}