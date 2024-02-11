namespace PE2_acceso_datos.Interfaz
{
    partial class Login_Usuarios_frm
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
            btnIngresar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtusuario = new TextBox();
            txtcontrasenia = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(250, 536);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 46);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(501, 665);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 132);
            label1.Name = "label1";
            label1.Size = new Size(103, 33);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(50, 185);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(559, 39);
            txtusuario.TabIndex = 3;
            // 
            // txtcontrasenia
            // 
            txtcontrasenia.Location = new Point(50, 315);
            txtcontrasenia.Name = "txtcontrasenia";
            txtcontrasenia.PasswordChar = '*';
            txtcontrasenia.Size = new Size(559, 39);
            txtcontrasenia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 262);
            label2.Name = "label2";
            label2.Size = new Size(141, 33);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // Login_Usuarios_frm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 745);
            Controls.Add(txtcontrasenia);
            Controls.Add(label2);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Name = "Login_Usuarios_frm";
            Text = "Inicio Sesion";
            Load += Login_Usuarios_frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtusuario;
        private TextBox txtcontrasenia;
        private Label label2;
    }
}