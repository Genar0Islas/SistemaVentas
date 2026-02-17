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
    public partial class FrmListadoCategoria : Form
    {
        public FrmListadoCategoria()
        {
            InitializeComponent();
        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
        }
        public void Mostrar()
        {
            this.dlistado.DataSource = CNCategoria.Listar();
        }

        public void Buscar()
        {
            this.dlistado.DataSource = CNCategoria.BuscarNombre(this.txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria form = new FrmRegistrarCategoria();
            form.Show();
            form.Insert = true;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria form = new FrmRegistrarCategoria();

            form.Edit = true;
            form.Insert = false;

            form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();

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
                        string idcategoria = dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
                        CNCategoria.Eliminar(Convert.ToInt32(idcategoria));

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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
