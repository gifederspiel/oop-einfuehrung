using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    public class Controller
    {
        int breite;
        int höhe;

        public int Breite
        {
            get { return breite; }
        }
        public int Höhe
        {
            get { return höhe; }
        }

        public void EinlesenBreite(int b)
        {
            if (b <= 0)
            {
                throw new Exception("Ungültiger Wert für Breite");
            }
            breite = b;
        }

        public void EinlesenHöhe(int h)
        {
            if (h <= 0)
            {
                throw new Exception("Ungültiger Wert für Höhe");
            }
            höhe = h;
        }
        public int Ausrechnen(int breite, int höhe)
        {
            return breite * höhe;
        }
    }
}
