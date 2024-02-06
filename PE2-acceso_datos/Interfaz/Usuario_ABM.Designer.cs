namespace PE2_acceso_datos.Interfaz
{
    partial class Usuario_ABM
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
            dtgUsuarios = new DataGridView();
            IdUsuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasenia = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtcodusuario = new TextBox();
            txtnombre = new TextBox();
            lblnombre = new Label();
            txtUsuarioLogin = new TextBox();
            lblusername = new Label();
            txtApellido = new TextBox();
            lblapellido = new Label();
            txtcorreo = new TextBox();
            label2 = new Label();
            txtcontraseña = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Nombre, Apellido, NombreUsuario, Contrasenia, mail });
            dtgUsuarios.Location = new Point(12, 92);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowTemplate.Height = 25;
            dtgUsuarios.Size = new Size(665, 254);
            dtgUsuarios.TabIndex = 0;
            dtgUsuarios.TabStop = false;
            dtgUsuarios.CellDoubleClick += dtgUsuarios_CellDoubleClick;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "Cod. Usuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 70;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 120;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "UserName";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contrasenia
            // 
            Contrasenia.DataPropertyName = "Contrasenia";
            Contrasenia.HeaderText = "Password";
            Contrasenia.Name = "Contrasenia";
            Contrasenia.ReadOnly = true;
            // 
            // mail
            // 
            mail.DataPropertyName = "Mail";
            mail.HeaderText = "Mail";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Cod. Usuario";
            // 
            // txtcodusuario
            // 
            txtcodusuario.Location = new Point(12, 37);
            txtcodusuario.Name = "txtcodusuario";
            txtcodusuario.ReadOnly = true;
            txtcodusuario.Size = new Size(100, 23);
            txtcodusuario.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(125, 37);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 5;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.Location = new Point(125, 19);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(98, 15);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "Nombre Usuario";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(352, 37);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(100, 23);
            txtUsuarioLogin.TabIndex = 15;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(352, 19);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(69, 15);
            lblusername.TabIndex = 7;
            lblusername.Text = "User Name";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(239, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblapellido.Location = new Point(239, 19);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(97, 15);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "Apellido Usuario";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(577, 37);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(100, 23);
            txtcorreo.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(577, 19);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Mail";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(464, 37);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(100, 23);
            txtcontraseña.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(464, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(126, 389);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(239, 389);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(352, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(13, 389);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Usuario_ABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 437);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtcorreo);
            Controls.Add(label2);
            Controls.Add(txtcontraseña);
            Controls.Add(label3);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lblusername);
            Controls.Add(txtApellido);
            Controls.Add(lblapellido);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(txtcodusuario);
            Controls.Add(label1);
            Controls.Add(dtgUsuarios);
            Name = "Usuario_ABM";
            Text = "Registro de Usuarios";
            Load += Usuario_ABM_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contrasenia;
        private DataGridViewTextBoxColumn mail;
        private Label label1;
        private TextBox txtcodusuario;
        private TextBox txtnombre;
        private Label lblnombre;
        private TextBox txtUsuarioLogin;
        private Label lblusername;
        private TextBox txtApellido;
        private Label lblapellido;
        private TextBox txtcorreo;
        private Label label2;
        private TextBox txtcontraseña;
        private Label label3;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnNuevo;
    }
}