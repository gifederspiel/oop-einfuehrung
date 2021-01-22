using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    class Auto
    {
        public bool MotorGestartet { get; private set; }
        public bool SlowDown { get; set; }
        public bool Driving { get; set; }
        public int MaxSpeed { get; private set; }
        public int Acceleration { get; private set; }
        public string Marke { get; private set; }
        public int PS { get; private set; }
        public int CurrentSpeed { get; private set; }
        public int CurrentGear { get; private set; }
        
        ///Konstruktor
        public Auto(string marke, int ps)
        {
            Marke = marke;
            PS = ps;
            MaxSpeed = ps / 2 * 3;
            Acceleration = ps / 25;
            CurrentSpeed = 0;
            CurrentGear = 0;
        }
        public void StarteMotor()
        {
            MotorGestartet = true;
        }
        public void StoppeMotor()
        {
            MotorGestartet = false;
        }

        public override string ToString()
        {
            return Marke;
        }
        public void Speed()
        {
            if(MotorGestartet == false)
            {
                return;
            }
            if(CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += Acceleration;
            }
            UpdateGear();
        }
        public void Bremsen()
        {
            if (CurrentSpeed > 0)
            {
                CurrentSpeed -= 12;
                SlowDown = false;
            }
            if (MotorGestartet == false)
            {
                return;
            }
            UpdateGear();
        }
        private void UpdateGear()
        {
            if (CurrentSpeed >= 0 && CurrentSpeed <= 10)
            {
                CurrentGear = 1;
            }
            else if (CurrentSpeed >= 11 && CurrentSpeed <= 20)
            {
                CurrentGear = 2;
            }
            else if (CurrentSpeed >= 21 && CurrentSpeed <= 40)
            {
                CurrentGear = 3;
            }
            else if (CurrentSpeed >= 41 && CurrentSpeed <= 70)
            {
                CurrentGear = 4;
            }
            else if (CurrentSpeed >= 71 && CurrentSpeed <= 100)
            {
                CurrentGear = 5;
            }
            else if (CurrentGear >= 101 && CurrentSpeed <= MaxSpeed)
            {
                CurrentGear = 6;
            }
        }

        
    }
}
