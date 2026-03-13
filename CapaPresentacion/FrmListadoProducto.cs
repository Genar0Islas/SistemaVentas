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
    public partial class FrmListadoProducto : Form
    {
        public FrmListadoProducto()
        {
            InitializeComponent();
        }

        private void FrmListadoProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CapaNegocio.CNProducto.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CapaNegocio.CNProducto.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarCodigo()
        {
            this.dlistado.DataSource = CapaNegocio.CNProducto.BuscarCodigo(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtncodigo.Checked)
            {
                BuscarCodigo();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema de Venta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistarProducto form = new FrmRegistarProducto();
            form.Show();
            form.Insert = true;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistarProducto form = new FrmRegistarProducto();
            form.Show();
            form.Edit = true;

            form.txtidproducto.Text = this.dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
            form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
            form.txtnombreproducto.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.txtpreciocompra.Text = this.dlistado.CurrentRow.Cells["precio_compra"].Value.ToString();
            form.txtprecioventa.Text = this.dlistado.CurrentRow.Cells["precio_venta"].Value.ToString();
            form.dateTimefingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_ingreso"].Value);
            form.dateTimefvencimiento.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_vencimiento"].Value);
            form.txtstock.Text = this.dlistado.CurrentRow.Cells["stock"].Value.ToString();
            form.cmbcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();

            string estado = this.dlistado.CurrentRow.Cells["estado"].Value.ToString();

            if (estado == "Activo")
            {
                form.rbtactivo.Checked = true;
            }
            else
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
                Opcion = MessageBox.Show("¿Realmente desea eliminar el producto?", "Sistema de Venta",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";
                    Codigo = this.dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
                    Rpta = CapaNegocio.CNProducto.Eliminar(Convert.ToInt32(Codigo));
                    if (Rpta.Equals("OK"))
                    {
                        this.Mostrar();
                        MessageBox.Show("Producto eliminado correctamente", "Sistema de Venta", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}