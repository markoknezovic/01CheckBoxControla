using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Check_box_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tekst.Text = "";
            Tekst.Visible = true;
            Tekst.Text += "Odabrali ste : " + System.Environment.NewLine;

            if (Dorucak.Checked) { Tekst.Text += "Dorucak" + System.Environment.NewLine;
            }

            if (Rucak.Checked) { Tekst.Text += "Rucak" + System.Environment.NewLine;
            }

            if (Vecera.Checked) { Tekst.Text += "Vecera" + System.Environment.NewLine;
            }

            if (SakrijNarudzbu.Checked) { Tekst.Visible = false;
            }
        }
    }
}
