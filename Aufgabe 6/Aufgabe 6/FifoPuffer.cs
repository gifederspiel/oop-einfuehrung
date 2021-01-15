using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
{
    class FifoPuffer
    {
        int[] pufferarr = new int[1];
        
        public FifoPuffer(int size)
        {
            Array.Resize(ref pufferarr, size);
        }
        

        public void Put(int eingabewert)
        {
            for (int i = 0; i < pufferarr.Length; i++)
            {
                if (pufferarr[i] == 0)
                {
                    pufferarr[i] = eingabewert;
                    break;
                }
                
            }
        }
        public String Get()
        {
            String resstring = "";
            int firstint = pufferarr[0];
            int result = firstint;
            for (int j = 0; j < pufferarr.Length - 1; j++)
            {
                pufferarr[j] = pufferarr[j + 1];
                pufferarr[pufferarr.Length-1] = 0;
            }
            if (firstint != 0)
            {
                resstring = Convert.ToString(firstint);

                
            }
            else
            {
                resstring = "Der Puffer ist leer";
                
                
            }
            return resstring;
            
        }
        public String Getall()
        {
            int stop = 0;

            String ergebnis = "";
            for (int k = 0; k < pufferarr.Length; k++)
            {

                if (pufferarr[k] != 0 && stop == 0)
                {
                    ergebnis += pufferarr[k];
                    ergebnis += ", ";
                    pufferarr[k] = 0;
                    
                }
                else
                {
                    ergebnis += "Der Puffer ist leer";
                    stop = 1;
                    break;
                }
            }
            return ergebnis;

            
            
            
        }

    }
}
