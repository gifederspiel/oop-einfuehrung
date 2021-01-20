using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_7
{
    public partial class wordcount : Form
    {
        public wordcount()
        {
            InitializeComponent();
        }

        private void countbtn_Click(object sender, EventArgs e)
        {
            WordTab wrdTb = new WordTab();
            Parser wrdCounter = new Parser(wrdTb);
            wrdCounter.Parse(input.Text);
            String table = wrdTb.GetTab();
            wrdTb.PrintTab(table, output);
        }
        
    }
}
