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

        int stammbreite;
        public int Stammbreite
        {
            get
            {
                return stammbreite;
            }
            set
            {
                stammbreite = value;
            }
        }
        int kronenhoehe;
        public int Kronenhoehe
        {
            get
            {
                return kronenhoehe;
            }
            set
            {
                kronenhoehe = value;
            }
        }
        int stammhoehe;
        public int Stammhoehe
        {
            get
            {
                return stammhoehe;
            }
            set
            {
                stammhoehe = value;
            }
        }

        public void Zeichnen()
        {
            ///Krone
            int kronenbreite = 2 * kronenhoehe -1;
            for (int i = 0; i < kronenhoehe*2; i += 2)
            {
                for (int j = 0; j < (kronenbreite - i)/2; j++)
                {
                    _zeichnung += "  ";
                }
                for (int k = 0; k <= i; k++)
                {
                    _zeichnung += "*";
                }
                _zeichnung += Environment.NewLine;
            }
            ///Stamm
            int distanz = 2 * kronenhoehe -1;
            for (int i = 0; i < stammhoehe; i++)
            {
                for (int k = 1; k <= (distanz - stammbreite) / 2; k++)
                {
                    _zeichnung += "  ";
                }
                for (int j = 0; j < stammbreite; j++)
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
