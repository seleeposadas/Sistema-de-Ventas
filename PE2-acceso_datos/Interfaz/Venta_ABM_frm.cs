using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
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
    public partial class Venta_ABM_frm : Form
    {
        Venta ven = new Venta();

        private bool modoEdicion = false;
        public Venta_ABM_frm()
        {
            InitializeComponent();
        }

        private void FormatearFormulario()
        {
            try
            {

                txtIdVenta.Text = "";
                txtComentario.Text = "";
                txtIdUsuario.Text = "";
                PopularVentas();
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


        private bool HabilitarComponentesFormulario(bool valor)
        {
            txtIdVenta.Enabled = valor;
            txtComentario.Enabled = valor;
            txtIdUsuario.Enabled = valor;
            return valor;
        }

        private void HabilitarBotones()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private bool corroborarCamposVacios()
        {
            bool correcto = true;
            try
            {
                if (txtComentario.Text == "")
                {

                    MessageBox.Show("Debe un comentario", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtComentario.Focus();
                }

                if (txtIdUsuario.Text == "")
                {

                    MessageBox.Show("Debe ingresar el codigo de Usuario", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtIdUsuario.Focus();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return correcto;
        }

        private void LeerTextbox(Venta ven)
        {
            try
            {
                ven.Comentarios = txtComentario.Text;
                ven.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void PopularVentas()
        {
            try
            {
                List<Venta> lstVenta = new List<Venta>();
                lstVenta = VentaData.PopularVenta();

                dtgVenta.DataSource = lstVenta;
                this.Refresh();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (corroborarCamposVacios())
                {
                    LeerTextbox(ven);

                    if (modoEdicion != true)
                    {
                        VentaData.RegistrarVenta(ven);
                        MessageBox.Show("La venta se ha registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        VentaData.ActualizarVenta(ven);
                        MessageBox.Show("La venta se ha actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenta = 0;
                if (dtgVenta.CurrentRow != null)
                {
                    idVenta = ((Venta)dtgVenta.CurrentRow.DataBoundItem).IdVenta;
                }
                Venta _ven = VentaData.ObtenerVentaxId(idVenta);

                if (_ven != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Confirma Eliminar la Venta Nro.: " + _ven.IdVenta + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        VentaData.EliminarVenta(_ven);
                        MessageBox.Show("La Venta " + _ven.IdVenta + " se eliminó correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormatearFormulario();
                        modoEdicion = false;
                        HabilitarComponentesFormulario(false);
                    }
                    else
                    {
                        MessageBox.Show("La venta no se eliminó");
                    }
                }
                else
                {
                    MessageBox.Show("Venta no encontrada");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dtgVenta.Rows[e.RowIndex];

                    ven.IdVenta = Convert.ToInt32(selectedRow.Cells["idVenta"].Value.ToString());
                    ven.Comentarios = selectedRow.Cells["comentario"].Value.ToString();
                    ven.IdUsuario = Convert.ToInt32(selectedRow.Cells["idUsuario"].Value);

                    txtComentario.Text = ven.Comentarios;
                    txtIdUsuario.Text = Convert.ToInt32(ven.IdUsuario).ToString();
                    modoEdicion = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private void txtIdUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Venta_ABM_frm_Load(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }
    }
}
