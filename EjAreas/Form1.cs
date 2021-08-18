using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbntRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbntRectangulo.Checked)
            {
                txtBase.Enabled = true;
                txtAltura.Enabled = true;
                txtRadio.Enabled = false;
            }
                
        }

        private void rbtnTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTriangulo.Checked)
            {
                txtRadio.Enabled = false;
                txtBase.Enabled = true;
                txtAltura.Enabled = true;
            }
                
        }

        private void rbtnCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCirculo.Checked)
            {
                txtBase.Enabled = false;
                txtAltura.Enabled = false;
                txtRadio.Enabled = true;
            }
                
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (rbntRectangulo.Checked && txtBase.Text.Length != 0 && txtAltura.Text.Length != 0)
                if (float.TryParse(txtBase.Text, out _) && float.TryParse(txtAltura.Text, out _))
                    txtArea.Text = Convert.ToString(int.Parse(txtBase.Text) * int.Parse(txtAltura.Text));


            if (rbtnTriangulo.Checked && txtBase.Text.Length != 0 && txtAltura.Text.Length != 0)
                if (float.TryParse(txtBase.Text, out _) && float.TryParse(txtAltura.Text, out _))
                    txtArea.Text = Convert.ToString((int.Parse(txtBase.Text) * int.Parse(txtAltura.Text)) / 2);

            if (rbtnCirculo.Checked && txtRadio.Text.Length != 0)
                if (float.TryParse(txtRadio.Text, out _))
                    txtArea.Text = Convert.ToString(int.Parse(txtRadio.Text) * int.Parse(txtRadio.Text) * System.Math.PI);
        }


    }
}
