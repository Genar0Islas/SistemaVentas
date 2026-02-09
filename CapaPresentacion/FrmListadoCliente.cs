using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoCliente : Form
    {
        public FrmListadoCliente()
        {
            InitializeComponent();
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }

        private void Mostrar()
        {
            this.dlistado.DataSource = CNCliente.Listar();
        }

        private void BuscarNombre()
        {
            this.dlistado.DataSource = CNCliente.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarDni()
        {
            this.dlistado.DataSource = CNCliente.BuscarDni(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtndni.Checked)
            {
                BuscarDni();
            } else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Edit = true;

            form.txtidcliente.Text = this.dlistado.CurrentRow.Cells["Idcliente"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["Nombre"].Value.ToString();
            form.txtapellidos.Text = this.dlistado.CurrentRow.Cells["Apellidos"].Value.ToString();
            form.txtdni.Text = this.dlistado.CurrentRow.Cells["DNI"].Value.ToString();
            form.txtrfc.Text = this.dlistado.CurrentRow.Cells["RFC"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["Telefono"].Value.ToString();

            string estado = this.dlistado.CurrentRow.Cells["Estado"].Value.ToString();

            if(estado == "ACTIVO")
            {
                form.rbtactivo.Checked = true;
            } else
            {
                form.rbtninactivo.Checked = true;
            }

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (Opcion == DialogResult.OK)
                    {
                        string idcliente = dlistado.CurrentRow.Cells["Idcliente"].Value.ToString();
                        CNCliente.Eliminar(Convert.ToInt32(idcliente));

                        MessageBox.Show("Registro eliminado", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
