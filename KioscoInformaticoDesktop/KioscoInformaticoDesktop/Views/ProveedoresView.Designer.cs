namespace KioscoInformaticoDesktop.Views
{
    partial class ProveedoresView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabLista = new TabPage();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            DataGridProveedores = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            comboCondicionIva = new ComboBox();
            label8 = new Label();
            txtCbu = new TextBox();
            label7 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            comboLocalidades = new ComboBox();
            label6 = new Label();
            txtTelefonos = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridProveedores).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 88);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(3, 95);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1036, 504);
            tabControl.TabIndex = 2;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnsalir);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(label3);
            tabLista.Controls.Add(txtFiltro);
            tabLista.Controls.Add(btnEliminar);
            tabLista.Controls.Add(btnEditar);
            tabLista.Controls.Add(btnAgregar);
            tabLista.Controls.Add(DataGridProveedores);
            tabLista.Location = new Point(4, 29);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(1028, 471);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 30;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(887, 328);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(121, 40);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(887, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 51);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 16);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(81, 11);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(506, 27);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(887, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(887, 186);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(887, 104);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // DataGridProveedores
            // 
            DataGridProveedores.AllowUserToAddRows = false;
            DataGridProveedores.AllowUserToDeleteRows = false;
            DataGridProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridProveedores.BackgroundColor = Color.LightBlue;
            DataGridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridProveedores.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridProveedores.Location = new Point(3, 47);
            DataGridProveedores.Name = "DataGridProveedores";
            DataGridProveedores.ReadOnly = true;
            DataGridProveedores.RowHeadersWidth = 51;
            DataGridProveedores.Size = new Size(856, 392);
            DataGridProveedores.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(comboCondicionIva);
            tabPageAgregarEditar.Controls.Add(label8);
            tabPageAgregarEditar.Controls.Add(txtCbu);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(BtnCancelar);
            tabPageAgregarEditar.Controls.Add(BtnGuardar);
            tabPageAgregarEditar.Controls.Add(comboLocalidades);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(txtTelefonos);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(1028, 471);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // comboCondicionIva
            // 
            comboCondicionIva.FormattingEnabled = true;
            comboCondicionIva.Location = new Point(342, 280);
            comboCondicionIva.Margin = new Padding(3, 4, 3, 4);
            comboCondicionIva.Name = "comboCondicionIva";
            comboCondicionIva.Size = new Size(225, 28);
            comboCondicionIva.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(218, 284);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 28;
            label8.Text = "Condición IVA:";
            // 
            // txtCbu
            // 
            txtCbu.Location = new Point(342, 220);
            txtCbu.Margin = new Padding(3, 4, 3, 4);
            txtCbu.Name = "txtCbu";
            txtCbu.Size = new Size(225, 27);
            txtCbu.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 231);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 26;
            label7.Text = "Cbu:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 30;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(493, 387);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(129, 45);
            BtnCancelar.TabIndex = 24;
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
            BtnGuardar.Location = new Point(158, 387);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(122, 45);
            BtnGuardar.TabIndex = 23;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // comboLocalidades
            // 
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(342, 333);
            comboLocalidades.Margin = new Padding(3, 4, 3, 4);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(225, 28);
            comboLocalidades.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 337);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 22;
            label6.Text = "Localidad:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(342, 181);
            txtTelefonos.Margin = new Padding(3, 4, 3, 4);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(225, 27);
            txtTelefonos.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 192);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 20;
            label5.Text = "Telefonos:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(338, 112);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(225, 27);
            txtDireccion.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 123);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 19;
            label4.Text = "Direccion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(342, 47);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 600);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProveedoresView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedoresView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridProveedores).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabLista;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label3;
        private TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView DataGridProveedores;
        private FontAwesome.Sharp.IconButton btnsalir;
        private TabPage tabPageAgregarEditar;
        private TextBox txtTelefonos;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox comboLocalidades;
        private Label label6;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox txtCbu;
        private Label label7;
        private ComboBox comboCondicionIva;
        private Label label8;
    }
}