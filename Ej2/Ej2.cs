using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Ej2
    {
        static String Dos(Byte numero)
        {
            switch (numero)
            {
                case 1:
                    return "uno";
                case 2:
                    return "dos";
                case 3:
                    return "tres";
                case 4:
                    return "cuatro";
                case 5:
                    return "cinco";
                case 6:
                    return "seis";
                case 7:
                    return "siete";
                case 8:
                    return "ocho";
                case 9:
                    return "nueve";
                default:
                    return "otro";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dos(1));
            Console.ReadKey();
        }
    }
}
