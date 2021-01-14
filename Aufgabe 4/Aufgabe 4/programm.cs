using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_4
{
    public partial class programm : Form
    {
        public Controller alter = new Controller();

        public programm()
        {
            InitializeComponent();
        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            DateTime gebdat = selector.Value;
            DateTime nowdat = DateTime.Today;

            if (jahre.Checked == true)
            {
                alter.BerechneJahre(gebdat, nowdat);
            }
            if (monate.Checked == true)
            {
                alter.BerechneMonate(gebdat, nowdat);
            }
            if (wochen.Checked == true)
            {
                alter.BerechneWochen(gebdat, nowdat);
            }
            if (tage.Checked == true)
            {
                alter.BerechneTage(gebdat, nowdat);
            }
            ausgabe.Text = alter.Ergebnis.ToString();
            
        }
    }
}
