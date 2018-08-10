using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Program
    {
        static void Main(string[] args)
        { string[] cadenas = new string[5];
            for (Byte i=4; i>=0; i--)
            {
                cadenas[i] = "";
                for (int j = args[i].Length - 1; j >= 0; j--)
                {
                    cadenas[i] += args[i][j];
                }

            }
            string buffer;
            int i = 0;
            while (i < 4)
            {
                if (String.Compare(cadenas[i], cadenas[i + 1]) = 1)
                {
                    
                }
            }

                
        }
    }
}
