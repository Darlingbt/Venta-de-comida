using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_comida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paqinf_CheckedChanged(object sender, EventArgs e)
        {
            if (paqinf.Checked == true)
            {
                txtcantpaqinf.Enabled = true;
            }
            else
            {
                txtcantpaqinf.Enabled = false;
                errorProvider1.SetError(txtcantpaqinf, "");
                txtcantpaqinf.Clear();

            }
        }

        private void paqduo_CheckedChanged(object sender, EventArgs e)
        {
            if (paqduo.Checked == true)
            {
                txtcantpaqduo.Enabled = true;
            }
            else
            {
                txtcantpaqduo.Enabled = false;
                errorProvider1.SetError(txtcantpaqduo, "");
                txtcantpaqduo.Clear();
            }
        }

        private void paqfam_CheckedChanged(object sender, EventArgs e)
        {
            if (paqfam.Checked == true)
            {
                txtcantpaqfam.Enabled = true;
            }
            else
            {
                txtcantpaqfam.Enabled = false;
                errorProvider1.SetError(txtcantpaqfam, "");
                txtcantpaqfam.Clear();

            }
        }

        private void paqtrio_CheckedChanged(object sender, EventArgs e)
        {
            if (paqtrio.Checked == true)
            {
                txtcantpaqtrio.Enabled = true;
            }
            else
            {
                txtcantpaqtrio.Enabled = false;
                errorProvider1.SetError(txtcantpaqtrio, "");
                txtcantpaqtrio.Clear();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                aceptar();
            }
            
        }
        void aceptar()
        {
            int cantinf = Convert.ToInt32(txtcantpaqinf.Text);
            int cantduo = Convert.ToInt32(txtcantpaqduo.Text);
            int cantfam = Convert.ToInt32(txtcantpaqfam.Text);
            int canttrio = Convert.ToInt32(txtcantpaqtrio.Text);
            const double preinf = 85.90, preduo = 90.00, prefam = 105, pretrio = 95.50;
           
            double subtotal, iva, totalapagar;

            subtotal = (cantinf * preinf) + (cantduo * preduo) + (cantfam * prefam) + (canttrio * pretrio);
            
            iva = subtotal * 0.18;

            totalapagar = subtotal - iva;

            txtsubt.Text = Convert.ToString(subtotal);
            txtiva.Text = Convert.ToString(iva);
            txttotalapag.Text = Convert.ToString(totalapagar);
        }
        
        private Boolean validar()
        {
            Boolean ok = true;

            if(txtcantpaqinf.Enabled == true)
            {

                if (txtcantpaqinf.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtcantpaqinf, "Por favor intruduzca una cantidad");
                }
            }
           
            if(txtcantpaqduo.Enabled == true)
            {
                if(txtcantpaqduo.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtcantpaqduo, "Por favor intruduzca una cantidad");
                }
            }

            if(txtcantpaqfam.Enabled == true)
            {
                if(txtcantpaqfam.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtcantpaqfam, "Por favor intruduzca una cantidad");
                }
            }

            if(txtcantpaqtrio.Enabled == true)
            {
                if (txtcantpaqtrio.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtcantpaqtrio, "Por favor intruduzca una cantidad");
                }
            }
            return ok;
        }

        private void txtcantpaqinf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            errorProvider1.SetError(txtcantpaqinf, "");
        }

        private void txtcantpaqduo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            errorProvider1.SetError(txtcantpaqduo, "");
        }

        private void txtcantpaqfam_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            errorProvider1.SetError(txtcantpaqfam, "");
        }

        private void txtcantpaqtrio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            errorProvider1.SetError(txtcantpaqtrio, "");
        }

        private void btnnuevacom_Click(object sender, EventArgs e)
        {
            nuevacompra();
        }
        void nuevacompra()
        {
            txtcantpaqinf.Clear();
            txtcantpaqduo.Clear();
            txtcantpaqfam.Clear();
            txtcantpaqtrio.Clear();
            txtsubt.Clear();
            txtiva.Clear();
            txttotalapag.Clear();
            paqinf.Checked = false;
            paqduo.Checked = false;
            paqfam.Checked = false;
            paqtrio.Checked = false;
            txtcantpaqinf.Enabled = false;
            txtcantpaqduo.Enabled = false;
            txtcantpaqfam.Enabled = false;
            txtcantpaqtrio.Enabled = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
