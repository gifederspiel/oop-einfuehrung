using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    public class Controller
    {
        public double _alter;
        public int intalter;


        public void BerechneJahre(DateTime g, DateTime n)
        {
            TimeSpan interval = n - g;
            _alter = interval.Days;
            _alter = _alter / 365;
            intalter = Convert.ToInt32(Math.Floor(_alter));

        }
        public void BerechneMonate(DateTime g, DateTime n)
        {
            TimeSpan interval = n - g;
            _alter = interval.Days;
            _alter = _alter / 30.4;
            intalter = Convert.ToInt32(Math.Floor(_alter));
        }
        public void BerechneWochen(DateTime g, DateTime n)
        {
            TimeSpan interval = n - g;
            _alter = interval.Days;
            _alter = _alter / 7;
            intalter = Convert.ToInt32(Math.Floor(_alter));
        }
        public void BerechneTage(DateTime g, DateTime n)
        {
            TimeSpan interval = n - g;
            _alter = interval.Days;
            intalter = Convert.ToInt32(Math.Floor(_alter));
        }



        public double Ergebnis
        {
            get
            {
                return intalter;
            }
            set
            {
                _alter = value;
            }
        }
    }
}
