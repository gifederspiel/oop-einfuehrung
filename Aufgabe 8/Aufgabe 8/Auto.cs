using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    class Auto
    {
        public bool MotorGestarted { get; private set; }
        public bool SlowDown { get; set; }
        public bool Driving { get; set; }
        public int MaxSpeed { get; private set; }
        public int Acceleration { get; private set; }
        public string Marke { get; }
        public int PS { get; }
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
            MotorGestarted = true;
        }
        public void StoppeMotor()
        {
            MotorGestarted = false;
        }

        public override string ToString()
        {
            return Marke;
        }
        public void Speed()
        {
            if(MotorGestarted == false)
            {
                return;
            }
            if(CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += Acceleration;
            }
        }
        public void Bremsen()
        {
            if (CurrentSpeed > 0)
            {
                CurrentSpeed -= 7;
            }
            else
            {
                CurrentSpeed = 0;
            }
        }
        public void UpdateGear()
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
