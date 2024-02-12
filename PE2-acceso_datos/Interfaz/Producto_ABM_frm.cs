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
    public partial class Producto_ABM_frm : Form
    {
        Producto pro = new Producto();

        private bool modoEdicion = false;

        public Producto_ABM_frm()
        {
            InitializeComponent();
        }

        private void Producto_ABM_frm_Load(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }

        private void FormatearFormulario()
        {
            try
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecioCompra.Text = "0";
                txtPrecioVenta.Text = "0";
                txtStock.Text = "0";
                txtIdUsuario.Text = "";
                PopularProductos();
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
            txtCodigo.Enabled = valor;
            txtNombre.Enabled = valor;
            txtPrecioCompra.Enabled = valor;
            txtPrecioVenta.Enabled = valor;
            txtStock.Enabled = valor;
            txtIdUsuario.Enabled = valor;
            dtgProducto.Enabled = valor;
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
                if (txtNombre.Text == "")
                {

                    MessageBox.Show("Debe ingresar un nombre", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtNombre.Focus();
                }

                if (txtPrecioCompra.Text == "0" || txtPrecioCompra.Text == "")
                {
                    MessageBox.Show("Debe ingresar el precio de compra del producto", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtPrecioCompra.Focus();
                }

                if (txtPrecioVenta.Text == "0" || txtPrecioVenta.Text == "")
                {
                    MessageBox.Show("Debe ingresar el precio para la venta del producto", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtPrecioVenta.Focus();
                }

                if (txtStock.Text == "0" || txtStock.Text == "")
                {

                    MessageBox.Show("Debe ingresar la cantidad de stock del producto", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtStock.Focus();
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

        private void LeerTextbox(Producto prod)
        {
            try
            {
                prod.Descripcion = txtNombre.Text;
                prod.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                prod.Costo = Convert.ToDecimal(txtPrecioCompra.Text);
                prod.Stock = Convert.ToInt32(txtStock.Text);
                prod.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void PopularProductos()
        {
            try
            {
                List<Producto> lstProducto = new List<Producto>();
                lstProducto = ProductoNegocio.PopularProducto();

                dtgProducto.DataSource = lstProducto;
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
                    LeerTextbox(pro);

                    if (modoEdicion == false)
                    {
                        ProductoNegocio.RegistrarProducto(pro);
                        MessageBox.Show("El producto se registro correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ProductoNegocio.ActualizarProducto(pro);
                        MessageBox.Show("El producto se actualizó correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dtgProducto.RowCount > 0)
                {
                    int idProducto = 0;
                    if (dtgProducto.CurrentRow != null)
                    {
                        idProducto = ((Producto)dtgProducto.CurrentRow.DataBoundItem).IdProducto;
                    }

                    Producto _prod = ProductoNegocio.ObtenerProductoxId(idProducto);

                    if (_prod != null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Confirma Eliminar el Producto Nro.: " + _prod.IdProducto + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            ProductoNegocio.EliminarProducto(_prod);
                            MessageBox.Show("El Producto " + _prod.IdProducto + " se eliminó correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FormatearFormulario();
                            modoEdicion = false;
                            HabilitarComponentesFormulario(false);
                        }
                        else
                        {
                            MessageBox.Show("El Producto no se eliminó");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
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

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dtgProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dtgProducto.Rows[e.RowIndex];

                    pro.IdProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value.ToString());
                    pro.Descripcion = selectedRow.Cells["Descripcion"].Value.ToString();
                    pro.Costo = Convert.ToDecimal(selectedRow.Cells["Costo"].Value.ToString());
                    pro.PrecioVenta = Convert.ToDecimal(selectedRow.Cells["PrecioVenta"].Value.ToString());
                    pro.Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value.ToString());
                    pro.IdUsuario = Convert.ToInt32(selectedRow.Cells["Usuario"].Value);

                    txtNombre.Text = pro.Descripcion;
                    txtPrecioCompra.Text = Convert.ToInt32(pro.Costo).ToString("N2");
                    txtPrecioVenta.Text = Convert.ToDecimal(pro.PrecioVenta).ToString("N2");
                    txtStock.Text = Convert.ToInt32(pro.Stock).ToString("N2");
                    txtIdUsuario.Text = Convert.ToInt32(pro.IdUsuario).ToString();
                    modoEdicion = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }
    }
}
