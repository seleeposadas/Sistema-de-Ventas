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
            idprodvendido = new DataGridViewTextBoxColumn();
            idproducto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            idventa = new DataGridViewTextBoxColumn();
            comentario = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(55, 409);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(394, 409);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(281, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(168, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtidventa
            // 
            txtidventa.Location = new Point(425, 57);
            txtidventa.Name = "txtidventa";
            txtidventa.Size = new Size(100, 23);
            txtidventa.TabIndex = 15;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(425, 39);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(66, 15);
            lblusername.TabIndex = 52;
            lblusername.Text = "Cod. Venta";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(312, 57);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 10;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblapellido.Location = new Point(312, 39);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(55, 15);
            lblapellido.TabIndex = 51;
            lblapellido.Text = "Cantidad";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(198, 57);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(100, 23);
            txtidproducto.TabIndex = 5;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.Location = new Point(198, 39);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(85, 15);
            lblnombre.TabIndex = 49;
            lblnombre.Text = "Cod. Producto";
            // 
            // txtcodprdVendido
            // 
            txtcodprdVendido.Location = new Point(54, 57);
            txtcodprdVendido.Name = "txtcodprdVendido";
            txtcodprdVendido.ReadOnly = true;
            txtcodprdVendido.Size = new Size(129, 23);
            txtcodprdVendido.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 48;
            label1.Text = "Cod. Prod. Vendido";
            // 
            // dtgProductoVendido
            // 
            dtgProductoVendido.AllowUserToAddRows = false;
            dtgProductoVendido.AllowUserToDeleteRows = false;
            dtgProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductoVendido.Columns.AddRange(new DataGridViewColumn[] { idprodvendido, idproducto, descripcion, cantidad, idventa, comentario });
            dtgProductoVendido.Location = new Point(54, 112);
            dtgProductoVendido.Name = "dtgProductoVendido";
            dtgProductoVendido.ReadOnly = true;
            dtgProductoVendido.RowHeadersVisible = false;
            dtgProductoVendido.RowHeadersWidth = 82;
            dtgProductoVendido.RowTemplate.Height = 25;
            dtgProductoVendido.Size = new Size(665, 254);
            dtgProductoVendido.TabIndex = 46;
            dtgProductoVendido.TabStop = false;
            dtgProductoVendido.CellDoubleClick += dtgProductoVendido_CellDoubleClick;
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
            // descripcion
            // 
            descripcion.DataPropertyName = "Descripcion";
            descripcion.HeaderText = "Denominacion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
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
            // comentario
            // 
            comentario.DataPropertyName = "Comentario";
            comentario.HeaderText = "Comentario";
            comentario.Name = "comentario";
            comentario.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(644, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 53;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Producto_Vendido_ABM_frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 439);
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
            Margin = new Padding(2, 1, 2, 1);
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
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn idventa;
        private DataGridViewTextBoxColumn comentario;
    }
}