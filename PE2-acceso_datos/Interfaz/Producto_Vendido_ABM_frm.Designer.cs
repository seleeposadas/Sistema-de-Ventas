namespace PE2_acceso_datos.Interfaz
{
    partial class Producto_Vendido_ABM_frm
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
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtidventa = new TextBox();
            lblusername = new Label();
            txtcantidad = new TextBox();
            lblapellido = new Label();
            txtidproducto = new TextBox();
            lblnombre = new Label();
            txtcodprdVendido = new TextBox();
            label1 = new Label();
            dtgProductoVendido = new DataGridView();
            btnSalir = new Button();
            idprodvendido = new DataGridViewTextBoxColumn();
            idproducto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            idventa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(102, 872);
            btnNuevo.Margin = new Padding(6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(139, 49);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(732, 872);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 49);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(522, 872);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(312, 872);
            btnGuardar.Margin = new Padding(6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 49);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtidventa
            // 
            txtidventa.Location = new Point(790, 121);
            txtidventa.Margin = new Padding(6);
            txtidventa.Name = "txtidventa";
            txtidventa.Size = new Size(182, 39);
            txtidventa.TabIndex = 15;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(790, 83);
            lblusername.Margin = new Padding(6, 0, 6, 0);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(137, 32);
            lblusername.TabIndex = 52;
            lblusername.Text = "Cod. Venta";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(580, 121);
            txtcantidad.Margin = new Padding(6);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(182, 39);
            txtcantidad.TabIndex = 10;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblapellido.Location = new Point(580, 83);
            lblapellido.Margin = new Padding(6, 0, 6, 0);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(116, 32);
            lblapellido.TabIndex = 51;
            lblapellido.Text = "Cantidad";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(368, 121);
            txtidproducto.Margin = new Padding(6);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(182, 39);
            txtidproducto.TabIndex = 5;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.Location = new Point(368, 83);
            lblnombre.Margin = new Padding(6, 0, 6, 0);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(179, 32);
            lblnombre.TabIndex = 49;
            lblnombre.Text = "Cod. Producto";
            // 
            // txtcodprdVendido
            // 
            txtcodprdVendido.Location = new Point(100, 121);
            txtcodprdVendido.Margin = new Padding(6);
            txtcodprdVendido.Name = "txtcodprdVendido";
            txtcodprdVendido.ReadOnly = true;
            txtcodprdVendido.Size = new Size(236, 39);
            txtcodprdVendido.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 83);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 48;
            label1.Text = "Cod. Prod. Vendido";
            // 
            // dtgProductoVendido
            // 
            dtgProductoVendido.AllowUserToAddRows = false;
            dtgProductoVendido.AllowUserToDeleteRows = false;
            dtgProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductoVendido.Columns.AddRange(new DataGridViewColumn[] { idprodvendido, idproducto, cantidad, idventa });
            dtgProductoVendido.Location = new Point(100, 238);
            dtgProductoVendido.Margin = new Padding(6);
            dtgProductoVendido.Name = "dtgProductoVendido";
            dtgProductoVendido.ReadOnly = true;
            dtgProductoVendido.RowHeadersVisible = false;
            dtgProductoVendido.RowHeadersWidth = 82;
            dtgProductoVendido.RowTemplate.Height = 25;
            dtgProductoVendido.Size = new Size(1235, 542);
            dtgProductoVendido.TabIndex = 46;
            dtgProductoVendido.TabStop = false;
            dtgProductoVendido.CellDoubleClick += dtgProductoVendido_CellDoubleClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1196, 872);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 53;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // idprodvendido
            // 
            idprodvendido.DataPropertyName = "IdProductoVendido";
            idprodvendido.HeaderText = "Cod.Prod.Vendido";
            idprodvendido.MinimumWidth = 20;
            idprodvendido.Name = "idprodvendido";
            idprodvendido.ReadOnly = true;
            idprodvendido.Width = 220;
            // 
            // idproducto
            // 
            idproducto.DataPropertyName = "IdProducto";
            idproducto.HeaderText = "Cod. Producto";
            idproducto.MinimumWidth = 20;
            idproducto.Name = "idproducto";
            idproducto.ReadOnly = true;
            idproducto.Width = 200;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Stock";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 20;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 200;
            // 
            // idventa
            // 
            idventa.DataPropertyName = "IdVenta";
            idventa.HeaderText = "Nro. Venta";
            idventa.MinimumWidth = 20;
            idventa.Name = "idventa";
            idventa.ReadOnly = true;
            idventa.Width = 200;
            // 
            // Producto_Vendido_ABM_frm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 1005);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtidventa);
            Controls.Add(lblusername);
            Controls.Add(txtcantidad);
            Controls.Add(lblapellido);
            Controls.Add(txtidproducto);
            Controls.Add(lblnombre);
            Controls.Add(txtcodprdVendido);
            Controls.Add(label1);
            Controls.Add(dtgProductoVendido);
            Name = "Producto_Vendido_ABM_frm";
            Text = "Producto Vendido";
            Load += Producto_Vendido_ABM_frm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProductoVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtcorreo;
        private Label label2;
        private TextBox txtcontraseña;
        private Label label3;
        private TextBox txtidventa;
        private Label lblusername;
        private TextBox txtcantidad;
        private Label lblapellido;
        private TextBox txtidproducto;
        private Label lblnombre;
        private TextBox txtcodprdVendido;
        private Label label1;
        private DataGridView dtgProductoVendido;
        private Button btnSalir;
        private DataGridViewTextBoxColumn idprodvendido;
        private DataGridViewTextBoxColumn idproducto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn idventa;
    }
}