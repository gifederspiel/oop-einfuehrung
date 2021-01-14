using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    public class Controller
    {
        public int _reisedauer = 0;
        public int entfernung = 384403;

        public void Berechnenstunden(int geschw)
        {
            _reisedauer = entfernung / geschw;
        }
        public void Berechnentage(int geschw)
        {
            int temp = entfernung / geschw;
            _reisedauer = temp / 24;
        }
        public int Ergebnis
        {
            get
            {
                return _reisedauer;
            }
            set
            {
                _reisedauer = value;
            }
        }


    }
}
