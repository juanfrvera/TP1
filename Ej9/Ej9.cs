﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Ej9
    {
        static void Main(string[] args)
        {
            UInt32 suma = 0;
            for (UInt16 i = 35; i <= 1977; i+=2)
            {
                bool control = true;
                UInt16 divisor = 3;
                while (control == true && divisor <= Convert.ToUInt16(i / 2))
                {
                    if (i % divisor == 0)
                    {
                        control = false;
                    }
                    h++;
                }
                if (control == true)
                {
                    suma += i;
                }
            }
            Console.Write("La suma de los numeros primos es: {0}",suma);
            Console.ReadKey();
        }
    }
}