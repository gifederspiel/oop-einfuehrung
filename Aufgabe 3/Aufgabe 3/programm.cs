using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_3
{
    public partial class programm : Form
    {
        public Controller reisedauer = new Controller();

        public programm()
        {
            InitializeComponent();
        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            int geschwindigkeit = Convert.ToInt32(inputKmh.Text);
            
            if (inTagen.Checked == true)
            {
                reisedauer.Berechnentage(Convert.ToInt32(geschwindigkeit));
            }
            if (inStunden.Checked == true)
            {
                reisedauer.Berechnenstunden(Convert.ToInt32(geschwindigkeit));
            }
            ausgabe.Text = reisedauer.Ergebnis.ToString();
        }
    }
}
