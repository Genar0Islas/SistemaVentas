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
    public partial class FrmRegistarProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
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
                if (this.txtnombreproducto.Text == string.Empty || this.txtdescripcion.Text == string.Empty
                    )
                {
                    MessageBox.Show("Ingresa los datos del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(this.txtcodigo.Text,
                                            this.txtnombreproducto.Text,
                                            this.txtdescripcion.Text,
                                            this.dateTimefingreso.
                                            
                                            , this.dateTimefvencimiento.MaxDate,
                                            Convert.ToDouble(this.txtpreciocompra.Text),
                                            Convert.ToDouble(this.txtprecioventa.Text),
                                            Convert.ToInt32(this.txtstock.Text),
                                            estado, Convert.ToInt32(this.txtidcategoria.Text));
                        
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNProducto.Editar(this.txtcodigo.Text,
                            this.txtnombreproducto.Text,
                            this.txtdescripcion.Text,
                            this.dateTimefingreso.MinDate, this.dateTimefvencimiento.MaxDate,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtstock.Text),
                            estado, Convert.ToInt32(this.txtidcategoria.Text));
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
    }
    }

