using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2_acceso_datos.Interfaz
{
    public partial class Menu_Principal_frm : Form
    {
        public Menu_Principal_frm()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario_ABM frm = new Usuario_ABM();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Usuarios_frm frm = new Login_Usuarios_frm();
            frm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Producto_ABM_frm frm = new Producto_ABM_frm();
            frm.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta_ABM_frm frm = new Venta_ABM_frm();
            frm.ShowDialog();
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            Producto_Vendido_ABM_frm frm = new Producto_Vendido_ABM_frm();
            frm.ShowDialog();
        }
    }
}
