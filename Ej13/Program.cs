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

        {
            int i = 0;
            string[] cadenas = new string[5];
            for ( i=4; i>=0; i--)
            {
                cadenas[i] = "";
                for (int j = args[i].Length - 1; j >= 0; j--)
                {
                    cadenas[i] += args[i][j];
                }

            }
            string buffer;
            i = 0;
            while (i < 4)
            {
                int orden = String.Compare(cadenas[i], cadenas[i + 1], true);
                if (orden == -1)
                {
                    buffer = cadenas[i];
                    cadenas[i] = cadenas[i + 1];
                    cadenas[i + 1] = buffer;
                    i = 0;
                }
                else
                {
                    i++;
                }
                    
                
            }
            for (i=0;i<=cadenas.Length-1;i++)
            {
                Console.WriteLine(cadenas[i]);
            }

            Console.ReadKey();
                
        }
    }
}
