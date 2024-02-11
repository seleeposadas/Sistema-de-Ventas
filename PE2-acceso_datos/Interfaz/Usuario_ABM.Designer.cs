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
            btnSalir = new Button();
            IdUsuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasenia = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Nombre, Apellido, NombreUsuario, Contrasenia, mail });
            dtgUsuarios.Location = new Point(22, 196);
            dtgUsuarios.Margin = new Padding(6);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 82;
            dtgUsuarios.RowTemplate.Height = 25;
            dtgUsuarios.Size = new Size(1235, 542);
            dtgUsuarios.TabIndex = 0;
            dtgUsuarios.TabStop = false;
            dtgUsuarios.CellDoubleClick += dtgUsuarios_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 41);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 1;
            label1.Text = "Cod. Usuario";
            // 
            // txtcodusuario
            // 
            txtcodusuario.Location = new Point(22, 79);
            txtcodusuario.Margin = new Padding(6);
            txtcodusuario.Name = "txtcodusuario";
            txtcodusuario.ReadOnly = true;
            txtcodusuario.Size = new Size(182, 39);
            txtcodusuario.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(232, 79);
            txtnombre.Margin = new Padding(6);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(182, 39);
            txtnombre.TabIndex = 5;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.Location = new Point(232, 41);
            lblnombre.Margin = new Padding(6, 0, 6, 0);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(203, 32);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "Nombre Usuario";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(654, 79);
            txtUsuarioLogin.Margin = new Padding(6);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(182, 39);
            txtUsuarioLogin.TabIndex = 15;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(654, 41);
            lblusername.Margin = new Padding(6, 0, 6, 0);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(139, 32);
            lblusername.TabIndex = 7;
            lblusername.Text = "User Name";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(444, 79);
            txtApellido.Margin = new Padding(6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 39);
            txtApellido.TabIndex = 10;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblapellido.Location = new Point(444, 41);
            lblapellido.Margin = new Padding(6, 0, 6, 0);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(205, 32);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "Apellido Usuario";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(1072, 79);
            txtcorreo.Margin = new Padding(6);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(182, 39);
            txtcorreo.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1072, 41);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 11;
            label2.Text = "Mail";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(862, 79);
            txtcontraseña.Margin = new Padding(6);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(182, 39);
            txtcontraseña.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(862, 41);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(234, 830);
            btnGuardar.Margin = new Padding(6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 49);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(444, 830);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(654, 830);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 49);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(24, 830);
            btnNuevo.Margin = new Padding(6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(139, 49);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1115, 830);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 46;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "Cod. Usuario";
            IdUsuario.MinimumWidth = 10;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 10;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 200;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "UserName";
            NombreUsuario.MinimumWidth = 10;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 200;
            // 
            // Contrasenia
            // 
            Contrasenia.DataPropertyName = "Contrasenia";
            Contrasenia.HeaderText = "Password";
            Contrasenia.MinimumWidth = 10;
            Contrasenia.Name = "Contrasenia";
            Contrasenia.ReadOnly = true;
            Contrasenia.Width = 200;
            // 
            // mail
            // 
            mail.DataPropertyName = "Mail";
            mail.HeaderText = "Mail";
            mail.MinimumWidth = 10;
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Width = 200;
            // 
            // Usuario_ABM
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 932);
            Controls.Add(btnSalir);
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
            Margin = new Padding(6);
            Name = "Usuario_ABM";
            Text = "Registro de Usuarios";
            Load += Usuario_ABM_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuarios;
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
        private Button btnSalir;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contrasenia;
        private DataGridViewTextBoxColumn mail;
    }
}