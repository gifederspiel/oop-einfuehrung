using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_2
{
    public partial class aufg2 : Form
    {
        public aufg2()
        {
            InitializeComponent();
        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            Controller ctrlr = new Controller();
            try
            { 
                ctrlr.EinlesenBreite(Convert.ToInt32(breite.Text));
                ctrlr.EinlesenHöhe(Convert.ToInt32(höhe.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ausgabeBox.Text = Convert.ToString(ctrlr.Ausrechnen(ctrlr.Breite, ctrlr.Höhe));
        }

        private void breite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void höhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
