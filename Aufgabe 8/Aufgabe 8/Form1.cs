using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_8
{
    public partial class Form1 : Form
    {
        private Auto selectedAuto { set; get; }
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add(new Auto("Porsche", 250));
            comboBox.Items.Add(new Auto("Opel", 90));
            comboBox.Items.Add(new Auto("Ferari", 370));

        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAuto = comboBox.SelectedItem as Auto;
            outputPS.Text = selectedAuto.PS.ToString();
            if (selectedAuto.MotorGestarted == true)
            {
                carKey1.BackColor = Color.Green;
            }
            else
            {
                carKey1.BackColor = Color.Red;
            }
            UpdateDisplay();

        }
        private void hupe_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\hupe.wav");
            player.Play();
        }
        

        private void Gas_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedAuto != null)
            {
                selectedAuto.Driving = true;
                while (selectedAuto.Driving)
                {
                    selectedAuto.Speed();
                    UpdateDisplay();
                    Application.DoEvents();
                }
            }
        }

        private void Gas_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedAuto != null)
            {
                selectedAuto.Driving = false;
            }
        }

        private void Bremse_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedAuto != null)
            {
                selectedAuto.SlowDown = true;
                while (selectedAuto.SlowDown)
                {
                    selectedAuto.Bremsen();
                    UpdateDisplay();
                    Application.DoEvents();

                }
            }
        }
        private void Bremse_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedAuto != null)
            {
                selectedAuto.SlowDown = false;
            }
        }

        public void UpdateDisplay()
        {
            kmh.Text = selectedAuto.CurrentSpeed.ToString();
            selectedAuto.UpdateGear();
            Gang.Text = selectedAuto.CurrentGear.ToString();
        }

        private void carKey1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedAuto != null)
            {
                if (selectedAuto.MotorGestarted == true)
                {
                    selectedAuto.StoppeMotor();

                }
                else
                {
                    selectedAuto.StarteMotor();
                }
                UpdateDisplay();
            }
            
        }
    }
}
