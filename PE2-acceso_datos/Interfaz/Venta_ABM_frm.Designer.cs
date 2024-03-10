namespace PE2_acceso_datos.Interfaz
{
    partial class Venta_ABM_frm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdVenta = new TextBox();
            txtComentario = new TextBox();
            txtIdUsuario = new TextBox();
            dtgVenta = new DataGridView();
            btnSalir = new Button();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            idVenta = new DataGridViewTextBoxColumn();
            comentario = new DataGridViewTextBoxColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 14);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(156, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 1;
            label2.Text = "Comentario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(666, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 14);
            label3.TabIndex = 2;
            label3.Text = "Cod. Usuario";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(26, 64);
            txtIdVenta.Margin = new Padding(2, 1, 2, 1);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.ReadOnly = true;
            txtIdVenta.Size = new Size(110, 23);
            txtIdVenta.TabIndex = 5;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(156, 64);
            txtComentario.Margin = new Padding(2, 1, 2, 1);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(496, 23);
            txtComentario.TabIndex = 10;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(666, 64);
            txtIdUsuario.Margin = new Padding(2, 1, 2, 1);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(110, 23);
            txtIdUsuario.TabIndex = 15;
            txtIdUsuario.KeyPress += txtIdUsuario_KeyPress_1;
            // 
            // dtgVenta
            // 
            dtgVenta.AllowUserToAddRows = false;
            dtgVenta.AllowUserToDeleteRows = false;
            dtgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVenta.Columns.AddRange(new DataGridViewColumn[] { idVenta, comentario, idUsuario, nombreUsuario });
            dtgVenta.Location = new Point(26, 105);
            dtgVenta.Margin = new Padding(2, 1, 2, 1);
            dtgVenta.Name = "dtgVenta";
            dtgVenta.ReadOnly = true;
            dtgVenta.RowHeadersVisible = false;
            dtgVenta.RowHeadersWidth = 82;
            dtgVenta.RowTemplate.Height = 41;
            dtgVenta.Size = new Size(769, 226);
            dtgVenta.TabIndex = 20;
            dtgVenta.CellDoubleClick += dtgVenta_CellDoubleClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(720, 352);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 45;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(27, 352);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 25;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(366, 352);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 352);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // idVenta
            // 
            idVenta.DataPropertyName = "IdVenta";
            idVenta.HeaderText = "Cod.Venta";
            idVenta.MinimumWidth = 10;
            idVenta.Name = "idVenta";
            idVenta.ReadOnly = true;
            idVenta.Width = 115;
            // 
            // comentario
            // 
            comentario.DataPropertyName = "Comentarios";
            comentario.HeaderText = "Comentario";
            comentario.MinimumWidth = 10;
            comentario.Name = "comentario";
            comentario.ReadOnly = true;
            comentario.Width = 350;
            // 
            // idUsuario
            // 
            idUsuario.DataPropertyName = "IdUsuario";
            idUsuario.HeaderText = "Cod. Usuario";
            idUsuario.MinimumWidth = 10;
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Width = 120;
            // 
            // nombreUsuario
            // 
            nombreUsuario.DataPropertyName = "NombreUsuario";
            nombreUsuario.HeaderText = "Nombre de Usuario";
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.ReadOnly = true;
            // 
            // Venta_ABM_frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 401);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dtgVenta);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentario);
            Controls.Add(txtIdVenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Venta_ABM_frm";
            Text = "Ventas";
            Load += Venta_ABM_frm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdVenta;
        private TextBox txtComentario;
        private TextBox txtIdUsuario;
        private DataGridView dtgVenta;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn idVenta;
        private DataGridViewTextBoxColumn comentario;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn nombreUsuario;
    }
}