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
    public partial class Producto_Vendido_ABM_frm : Form
    {
        ProductoVendido prodvendido = new ProductoVendido();

        private bool modoEdicion = false;
        public Producto_Vendido_ABM_frm()
        {
            InitializeComponent();
        }


        private void popularProductosVendidos()
        {
            try
            {
                List<ProductoVendido> listaProdVendidos = ProductoVendidoData.PopularProductoVendido();
                dtgProductoVendido.DataSource = listaProdVendidos;
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
                if (txtidproducto.Text == "")
                {

                    MessageBox.Show("Debe ingresar un código de producto", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtidproducto.Focus();
                }

                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("Debe ingresar la cantidad a vender", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtcantidad.Focus();
                }

                if (txtidventa.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nro de venta", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correcto = false;
                    return correcto;
                    txtidventa.Focus();
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
            txtidproducto.Enabled = valor;
            txtcantidad.Enabled = valor;
            txtidventa.Enabled = valor;
            dtgProductoVendido.Enabled = valor;
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
                txtidproducto.Text = "";
                txtcantidad.Text = "";
                txtidventa.Text = "";
                popularProductosVendidos();
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



        private void LeerTextbox(ProductoVendido prodv)
        {
            try
            {
                prodv.IdProducto = Convert.ToInt32(txtidproducto.Text);
                prodv.Stock = Convert.ToInt32(txtcantidad.Text);
                prodv.IdVenta = Convert.ToInt32(txtidventa.Text);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarComponentesFormulario(true);
            FormatearFormulario();
            HabilitarBotones();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (corroborarCamposVacios() == true)
                {
                    LeerTextbox(prodvendido);
                    if (modoEdicion == false)
                    {
                        ProductoVendidoData.RegistrarProductoVendido(prodvendido);
                        MessageBox.Show("El producto se Registró en una Venta Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ProductoVendidoData.ActualizarProductoVendido(prodvendido);
                        MessageBox.Show("El producto se actualizó en una Venta Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dtgProductoVendido.RowCount > 0)
                {
                    int _idProdVendido = 0;
                    if (dtgProductoVendido.CurrentRow != null)
                    {
                        _idProdVendido = ((ProductoVendido)dtgProductoVendido.CurrentRow.DataBoundItem).IdProductoVendido;
                    }

                    ProductoVendido _prodv = ProductoVendidoData.ObtenerProductoVendioxId(_idProdVendido);

                    if (_prodv != null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Confirma Eliminar el Producto Vendido Nro.: " + _prodv.IdProductoVendido + " de la venta Nro: " + _prodv.IdVenta + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            ProductoVendidoData.EliminarProducto(_prodv);
                            MessageBox.Show("El Producto " + _prodv.IdProductoVendido + " se eliminó correctamente de la venta Nro: " + _prodv.IdVenta, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            popularProductosVendidos();
                            FormatearFormulario();
                            modoEdicion = false;
                            HabilitarComponentesFormulario(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Producto no se eliminó");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProductoVendido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dtgProductoVendido.Rows[e.RowIndex];

                    prodvendido.IdProductoVendido = Convert.ToInt32(selectedRow.Cells["idprodvendido"].Value);
                    prodvendido.IdProducto = Convert.ToInt32(selectedRow.Cells["idproducto"].Value);
                    prodvendido.Stock = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                    prodvendido.IdVenta = Convert.ToInt32(selectedRow.Cells["idventa"].Value);

                    txtcodprdVendido.Text = prodvendido.IdProductoVendido.ToString();
                    txtidproducto.Text = prodvendido.IdProducto.ToString();
                    txtcantidad.Text = prodvendido.Stock.ToString();
                    txtidventa.Text = prodvendido.IdVenta.ToString();

                    modoEdicion = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private void Producto_Vendido_ABM_frm_Load(object sender, EventArgs e)
        {
            FormatearFormulario();
            HabilitarComponentesFormulario(false);
        }
    }
}
