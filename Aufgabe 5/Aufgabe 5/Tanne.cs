using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    public class Tanne
    {
        public string _zeichnung;

        public void Zeichnen(int hk, int hs, int b)
        {
            for (int i = 0; i < hk*2; i+=2)
            {
                for (int j = 1; j < b-i; i+=2)
                {
                    _zeichnung += " ";
                }
                for (int j = 1; j < i; i++)
                {
                    _zeichnung += "*";
                }
                _zeichnung += Environment.NewLine;

            }
            int distanz = 1 + b / 2;

            for (int stamm = 0; stamm < hs*2; stamm += 2)
            {
                for (int i = 0; i < distanz - b; i++)
                {
                    _zeichnung += " ";
                }
                for (int i = 0; i < b; i++)
                {
                    _zeichnung += "*";
                }
                _zeichnung += Environment.NewLine;
            }
        }
        public string Ergebnis
        {
            get
            {
                return _zeichnung;
            }
            set
            {
                _zeichnung = value;
            }
        }
    }
}
