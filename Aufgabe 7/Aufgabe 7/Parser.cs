using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    class Parser
    {
        WordTab tab;
        public Parser(WordTab wrdTb)
        {
            tab = wrdTb;
        }
        public void Parse(String text)
        {
            String word = "";
            char[] charArr = text.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals(' '))
                {
                    if (word != "")
                    {
                        tab.AddWord(word);
                        word = "";
                    }
                }
                else
                {
                    word += charArr[i];
                }
            }
            tab.AddWord(word);
            Console.WriteLine(word);
        }
        
        
        

    }
}
