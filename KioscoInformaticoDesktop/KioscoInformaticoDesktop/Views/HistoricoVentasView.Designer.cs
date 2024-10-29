namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            dataGridVentas = new DataGridView();
            panelFiltrado = new Panel();
            btnFiltrar = new Button();
            dateTimeHasta = new DateTimePicker();
            label3 = new Label();
            dateTimeDesde = new DateTimePicker();
            label2 = new Label();
            checkFiltrado = new CheckBox();
            numericTotalFacturado = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(306, 39);
            label1.TabIndex = 0;
            label1.Text = "Historial de ventas ";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridVentas.Location = new Point(11, 157);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersWidth = 51;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(722, 216);
            dataGridVentas.TabIndex = 4;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(136, 85);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(597, 66);
            panelFiltrado.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(479, 22);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(347, 21);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(111, 27);
            dateTimeHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 21);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(81, 21);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(100, 27);
            dateTimeDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 21);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Location = new Point(0, 88);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(130, 24);
            checkFiltrado.TabIndex = 0;
            checkFiltrado.Text = "Activar filtrado";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltrado_CheckedChanged;
            // 
            // numericTotalFacturado
            // 
            numericTotalFacturado.Enabled = false;
            numericTotalFacturado.Location = new Point(572, 411);
            numericTotalFacturado.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericTotalFacturado.Name = "numericTotalFacturado";
            numericTotalFacturado.Size = new Size(109, 27);
            numericTotalFacturado.TabIndex = 15;
            numericTotalFacturado.TextAlign = HorizontalAlignment.Right;
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericTotalFacturado);
            Controls.Add(checkFiltrado);
            Controls.Add(panelFiltrado);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            Text = "HistoricoVentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridVentas;
        private Panel panelFiltrado;
        private CheckBox checkFiltrado;
        private DateTimePicker dateTimeHasta;
        private Label label3;
        private DateTimePicker dateTimeDesde;
        private Label label2;
        private Button btnFiltrar;
        private NumericUpDown numericTotalFacturado;
    }
}