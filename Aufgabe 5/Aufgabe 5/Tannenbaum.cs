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
        public Tanne t = new Tanne();
        public Tannenbaum()
        {
            InitializeComponent();
        }

        private void zeichnen_Click(object sender, EventArgs e)
        {
            

            t.Stammbreite = Convert.ToInt32(inputbreite.Text);
            t.Stammhoehe = Convert.ToInt32(inputstammhoehe.Text);
            t.Kronenhoehe = Convert.ToInt32(inputkronenhoehe.Text);

            if (t.Stammbreite > 0 && t.Stammhoehe > 0 && t.Kronenhoehe >0)
            {
                t.Zeichnen();
            }

            ausgabe.Text = t.Ergebnis;
        }
    }
}
