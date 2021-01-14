using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_5
{
    public partial class Tannenbaum : Form
    {
        public Tanne zeichnung = new Tanne();
        public Tannenbaum()
        {
            InitializeComponent();
        }

        private void zeichnen_Click(object sender, EventArgs e)
        {
            int breite = Convert.ToInt32(inputbreite.Text);
            int stammhoehe = Convert.ToInt32(inputstammhoehe.Text);
            int kronenhoehe = Convert.ToInt32(inputkronenhoehe.Text);

            if (breite > 0 && stammhoehe > 0 && kronenhoehe >0)
            {
                zeichnung.Zeichnen(kronenhoehe, stammhoehe, breite);
            }

            ausgabe.Text = zeichnung.Ergebnis;
        }
    }
}
