namespace PE2_acceso_datos.Interfaz
{
    partial class Producto_ABM_frm
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
            btnSalir = new Button();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dtgProducto = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            txtStock = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIdUsuario = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProducto).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1357, 689);
            btnSalir.Margin = new Padding(6, 7, 6, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 55;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(69, 689);
            btnNuevo.Margin = new Padding(6, 7, 6, 7);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(139, 49);
            btnNuevo.TabIndex = 35;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(699, 689);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 49);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(489, 689);
            btnEliminar.Margin = new Padding(6, 7, 6, 7);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(279, 689);
            btnGuardar.Margin = new Padding(6, 7, 6, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 49);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtgProducto
            // 
            dtgProducto.AllowUserToAddRows = false;
            dtgProducto.AllowUserToDeleteRows = false;
            dtgProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducto.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Costo, PrecioVenta, Stock, Usuario });
            dtgProducto.Location = new Point(69, 186);
            dtgProducto.Margin = new Padding(2);
            dtgProducto.Name = "dtgProducto";
            dtgProducto.ReadOnly = true;
            dtgProducto.RowHeadersVisible = false;
            dtgProducto.RowHeadersWidth = 123;
            dtgProducto.RowTemplate.Height = 57;
            dtgProducto.Size = new Size(1427, 457);
            dtgProducto.TabIndex = 30;
            dtgProducto.TabStop = false;
            dtgProducto.CellDoubleClick += dtgProducto_CellDoubleClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "IdProducto";
            Codigo.HeaderText = "Cod.Prod";
            Codigo.MinimumWidth = 15;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Nombre";
            Descripcion.MinimumWidth = 15;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 300;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 15;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 200;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "Precio de Venta";
            PrecioVenta.MinimumWidth = 15;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 200;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 15;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 200;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "IdUsuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 15;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 200;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1065, 117);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Ingrese stock";
            txtStock.Size = new Size(196, 39);
            txtStock.TabIndex = 25;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(836, 117);
            txtPrecioCompra.Margin = new Padding(2);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PlaceholderText = "$$";
            txtPrecioCompra.Size = new Size(196, 39);
            txtPrecioCompra.TabIndex = 20;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(601, 117);
            txtPrecioVenta.Margin = new Padding(2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "$$";
            txtPrecioVenta.Size = new Size(196, 39);
            txtPrecioVenta.TabIndex = 15;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(289, 117);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese un nombre";
            txtNombre.Size = new Size(285, 39);
            txtNombre.TabIndex = 10;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(69, 117);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Ingrese un codigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(196, 39);
            txtCodigo.TabIndex = 5;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1065, 65);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 29);
            label5.TabIndex = 55;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(836, 65);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 29);
            label4.TabIndex = 54;
            label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(601, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 53;
            label3.Text = "Precio de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(289, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 52;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 29);
            label1.TabIndex = 51;
            label1.Text = "Codigo";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(1300, 117);
            txtIdUsuario.Margin = new Padding(2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.PlaceholderText = "Ingrese el Codigo del usuario";
            txtIdUsuario.Size = new Size(196, 39);
            txtIdUsuario.TabIndex = 30;
            txtIdUsuario.KeyPress += txtIdUsuario_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1300, 65);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(142, 29);
            label6.TabIndex = 57;
            label6.Text = "Cod. Usuario";
            // 
            // Producto_ABM_frm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 803);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dtgProducto);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Producto_ABM_frm";
            Text = "Productos";
            Load += Producto_ABM_frm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dtgProducto;
        private TextBox txtStock;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIdUsuario;
        private Label label6;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Usuario;
    }
}