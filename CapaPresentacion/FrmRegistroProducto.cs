using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistroProducto : Form
    {
        public FrmRegistroProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistroProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtninactivo.Checked == true)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }
            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingresa kis datos del cliente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Guardar(this.txtnombre.Text,
                                          this.txtapellidos.Text,
                                          this.txtrfc.Text,
                                          this.txtdni.Text,
                                          this.txttelefono.Text,
                                          estado);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(Convert.ToInt32(this.txtidcliente.Text),
                                                         this.txtnombre.Text,
                                                         this.txtapellidos.Text,
                                                         this.txtdni.Text,
                                                         this.txtrfc.Text,
                                                         this.txttelefono.Text,
                                                         estado);
                        MessageBox.Show("Cliente editado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCliente form = new FrmListadoCliente();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoCliente form = new FrmListadoCliente();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
