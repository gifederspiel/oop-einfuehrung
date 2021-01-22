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
        
        private void hupe_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\hupe.wav");
            player.Play();
        }
        private void SetzeOnOff()
        {
            carKey1.BackColor = Color.Red;

            if (selectedAuto != null && selectedAuto.MotorGestartet)
                carKey1.BackColor = Color.Green;
        }



        private void Gas_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedAuto != null)
            {
                selectedAuto.Driving = true;
                selectedAuto.SlowDown = false;
                while (selectedAuto.Driving == true)
                {
                    selectedAuto.Speed();
                    System.Threading.Thread.Sleep(200);
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
            if (selectedAuto == null)
            {
                return;
            }
            if (selectedAuto != null)
            {
                selectedAuto.SlowDown = true;
                selectedAuto.Driving = false;
                while (selectedAuto.SlowDown == true)
                {
                    selectedAuto.Bremsen();
                    System.Threading.Thread.Sleep(200);
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
            Gang.Text = selectedAuto.CurrentGear.ToString();
        }

        

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAuto = comboBox.SelectedItem as Auto;
            if (selectedAuto != null)
            {
                outputPS.Text = selectedAuto.PS.ToString() + " PS ";
                SetzeOnOff();
                UpdateDisplay();
            }
            else
            {
                outputPS.Text = "";

            }
        }

        private void carKey1_Click_1(object sender, EventArgs e)
        {
            if (selectedAuto != null)
            {
                if (carKey1.Checked == true)
                {
                    selectedAuto.StarteMotor();
                }
                else if (carKey1.Checked == false)
                {
                    selectedAuto.StoppeMotor();
                }
                
            }
            SetzeOnOff();

        }
    }
}
