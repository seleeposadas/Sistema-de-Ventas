using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
using Sistema_Venta_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2_acceso_datos.Interfaz
{
    public partial class Login_Usuarios_frm : Form
    {
        Usuario usu = new Usuario();

        public Login_Usuarios_frm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool validarTextbox()
        {
            bool correcto = true;
            try
            {
                if (txtusuario.Text == "")
                {

                    MessageBox.Show("Debe ingresar su usuario", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;

                }

                if (txtcontrasenia.Text == "")
                {
                    MessageBox.Show("Debe ingresar su contraseña", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return correcto;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = "";
            string password = "";

            usuario = txtusuario.Text;
            password = txtcontrasenia.Text;

            if (validarTextbox())
            {
                usu = UsuarioNegocio.Login(usuario, password);
                if (usu.IdUsuario != 0)
                {
                    Menu_Principal_frm menu = new Menu_Principal_frm();
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Usuarios_frm_Load(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontrasenia.Text = "";
        }
    }
}
