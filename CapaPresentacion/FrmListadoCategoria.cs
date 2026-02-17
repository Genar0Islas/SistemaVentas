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
    }
}
