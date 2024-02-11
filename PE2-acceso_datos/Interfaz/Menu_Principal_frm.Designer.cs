namespace PE2_acceso_datos.Interfaz
{
    partial class Menu_Principal_frm
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
            btnUsuarios = new Button();
            btnProductos = new Button();
            btnVenta = new Button();
            btnProductoVendido = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(108, 100);
            btnUsuarios.Margin = new Padding(2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(280, 46);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(108, 208);
            btnProductos.Margin = new Padding(2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(280, 46);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(108, 305);
            btnVenta.Margin = new Padding(2);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(280, 46);
            btnVenta.TabIndex = 2;
            btnVenta.Text = "Ventas";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(108, 397);
            btnProductoVendido.Margin = new Padding(2);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(280, 46);
            btnProductoVendido.TabIndex = 3;
            btnProductoVendido.Text = "Productos Vendidos";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(25, 511);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 46);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Menu_Principal_frm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 577);
            Controls.Add(btnSalir);
            Controls.Add(btnProductoVendido);
            Controls.Add(btnVenta);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Margin = new Padding(2);
            Name = "Menu_Principal_frm";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnProductos;
        private Button btnVenta;
        private Button btnProductoVendido;
        private Button btnSalir;
    }
}