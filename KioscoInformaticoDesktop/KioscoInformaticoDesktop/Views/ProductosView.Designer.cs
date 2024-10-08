namespace KioscoInformaticoDesktop.Views
{
    partial class ProductosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabLista = new TabPage();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            txtBusqueda = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            DataGridProductos = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            label4 = new Label();
            numericPrecio = new NumericUpDown();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(-5, 121);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(921, 478);
            tabControl.TabIndex = 3;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnSalir);
            tabLista.Controls.Add(btnFiltrar);
            tabLista.Controls.Add(label5);
            tabLista.Controls.Add(txtBusqueda);
            tabLista.Controls.Add(btnEliminar);
            tabLista.Controls.Add(btnEditar);
            tabLista.Controls.Add(btnAgregar);
            tabLista.Controls.Add(DataGridProductos);
            tabLista.Location = new Point(4, 29);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(913, 445);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(755, 277);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnFiltrar.IconColor = Color.Black;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 30;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(755, 13);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(121, 40);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 13);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 5;
            label5.Text = "Buscar Producto";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(135, 13);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(594, 27);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(755, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(755, 146);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(755, 76);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // DataGridProductos
            // 
            DataGridProductos.AllowUserToAddRows = false;
            DataGridProductos.AllowUserToDeleteRows = false;
            DataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridProductos.BackgroundColor = Color.Gray;
            DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridProductos.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridProductos.GridColor = SystemColors.ActiveCaptionText;
            DataGridProductos.Location = new Point(3, 76);
            DataGridProductos.Name = "DataGridProductos";
            DataGridProductos.ReadOnly = true;
            DataGridProductos.RowHeadersWidth = 51;
            DataGridProductos.Size = new Size(726, 365);
            DataGridProductos.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(numericPrecio);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(BtnCancelar);
            tabPageAgregarEditar.Controls.Add(BtnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(913, 445);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 8;
            // 
            // numericPrecio
            // 
            numericPrecio.Location = new Point(294, 108);
            numericPrecio.Margin = new Padding(3, 4, 3, 4);
            numericPrecio.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(137, 27);
            numericPrecio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 119);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 30;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(471, 348);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(129, 47);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 30;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(131, 348);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(122, 47);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(294, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 32);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre: ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 112);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductosView";
            tabControl.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridProductos).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabLista;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView DataGridProductos;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private NumericUpDown numericPrecio;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private Label label5;
        private TextBox txtBusqueda;
    }
}