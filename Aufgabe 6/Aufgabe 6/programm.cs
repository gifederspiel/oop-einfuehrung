using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FifoPuffer p;
        int i;

        private void createPuffer_Click(object sender, EventArgs e)
        {
            p = new FifoPuffer(Convert.ToInt32(puffervalue.Text));
        }

        private void putbutton_Click(object sender, EventArgs e)
        {
            p.Put(Convert.ToInt32(eingabe.Text));
        }

        private void getbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ausgabe.Text = Convert.ToString(p.Get());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void getallbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ausgabe.Text = p.Getall();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
