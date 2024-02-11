using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;


namespace PE2_acceso_datos.Interfaz
{
    public partial class Usuario_ABM : Form
    {
        Usuario usu = new Usuario();
        private bool modoEdicion = false;
        public Usuario_ABM()
        {
            InitializeComponent();
        }

        private void Usuario_ABM_Load(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }
        private void popularUsuarios()
        {
            try
            {
                List<Usuario> listaUsuarios = UsuarioData.PopularUsuarios();
                dtgUsuarios.DataSource = listaUsuarios;
                this.Refresh();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool corroborarCamposVacios()
        {
            bool correcto = true;
            try
            {
                if (txtnombre.Text == "")
                {

                    MessageBox.Show("Debe ingresar un nombre", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtnombre.Focus();
                }

                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Debe ingresar su apellido", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtApellido.Focus();
                }

                if (txtUsuarioLogin.Text == "")
                {
                    MessageBox.Show("Debe ingresar su usuario de login", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtUsuarioLogin.Focus();
                }

                if (txtcontraseña.Text == "")
                {

                    MessageBox.Show("Debe ingresar su contraseña", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtcontraseña.Focus();
                }

                if (txtcorreo.Text == "")
                {
                    MessageBox.Show("No ingresó su correo electrónico", "Faltan Datos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcorreo.Focus();
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return correcto;
        }

        private bool HabilitarComponentesFormulario(bool valor)
        {
            txtnombre.Enabled = valor;
            txtApellido.Enabled = valor;
            txtUsuarioLogin.Enabled = valor;
            txtcontraseña.Enabled = valor;
            txtcorreo.Enabled = valor;
            dtgUsuarios.Enabled = valor;
            return valor;
        }

        private void HabilitarBotones()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void FormatearFormulario()
        {
            try
            {
                txtcodusuario.Text = "";
                txtnombre.Text = "";
                txtApellido.Text = "";
                txtUsuarioLogin.Text = "";
                txtcorreo.Text = "";
                txtcontraseña.Text = "";
                popularUsuarios();
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarComponentesFormulario(true);
            FormatearFormulario();
            HabilitarBotones();
        }

        private void LeerTextbox(Usuario usu)
        {
            try
            {
                usu.Nombre = txtnombre.Text;
                usu.Apellido = txtApellido.Text;
                usu.NombreUsuario = txtUsuarioLogin.Text;
                usu.Contrasenia = txtcontraseña.Text;
                usu.Mail = txtcorreo.Text;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (corroborarCamposVacios() == true)
                {
                    LeerTextbox(usu);
                    if (modoEdicion == false)
                    {
                        UsuarioData.RegistrarUsuario(usu);
                        MessageBox.Show("El usuario se Registró Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UsuarioData.ActualizarUsuario(usu);
                        MessageBox.Show("El usuario se Modificó Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    FormatearFormulario();
                    modoEdicion = false;
                    HabilitarComponentesFormulario(false);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgUsuarios.RowCount > 0)
                {
                    int _idusuario = 0;
                    if (dtgUsuarios.CurrentRow != null)
                    {
                        _idusuario = ((Usuario)dtgUsuarios.CurrentRow.DataBoundItem).IdUsuario;
                    }

                    Usuario _usu = UsuarioData.ObtenerUsuarioxId(_idusuario);

                    if (usu != null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Confirma Eliminar el Usuario Nro.: " + _usu.IdUsuario + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            UsuarioData.EliminarUsuario(usu);
                            MessageBox.Show("El Usuario " + _usu.IdUsuario + " se eliminó correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            popularUsuarios();
                            FormatearFormulario();
                            modoEdicion = false;
                            HabilitarComponentesFormulario(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario no se eliminó");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dtgUsuarios.Rows[e.RowIndex];

                    usu.IdUsuario = Convert.ToInt32(selectedRow.Cells["idUsuario"].Value);
                    usu.Nombre = selectedRow.Cells["nombre"].Value.ToString();
                    usu.Apellido = selectedRow.Cells["apellido"].Value.ToString();
                    usu.NombreUsuario = selectedRow.Cells["NombreUsuario"].Value.ToString();
                    usu.Contrasenia = selectedRow.Cells["Contrasenia"].Value.ToString();
                    usu.Mail = selectedRow.Cells["Mail"].Value.ToString();

                    txtcodusuario.Text = usu.IdUsuario.ToString();
                    txtnombre.Text = usu.Nombre;
                    txtApellido.Text = usu.Apellido;
                    txtUsuarioLogin.Text = usu.NombreUsuario;
                    txtcontraseña.Text = usu.Contrasenia;
                    txtcorreo.Text = usu.Mail;
                    modoEdicion = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
