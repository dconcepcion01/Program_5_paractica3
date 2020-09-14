using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_paractica3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa te dice el mes que corresponde al numero que digite

          

            Console.WriteLine("DIGITE UN NUMERO DEL 1 AL 12 PARA DECIRLE A QUE MES CORRESPONDE ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)

            {
                case (1):
                    Console.WriteLine("El numero que digitaste corresponde a Enero:  " + "= 1");
                    break;

                case (2):
                    Console.WriteLine("El numero que digitaste corresponde a Febrero: " + "= 2");
                    break;

                case (3):
                    Console.WriteLine("El numero que digitaste corresponde a Marzo:  " + " = 3");
                    break;

                case (4):
                    Console.WriteLine("El numero que digitaste corresponde a Abril:  " + "= 4");
                    break;

                case (5):
                    Console.WriteLine("El numero que digitaste corresponde a Mayo: " + " = 5");
                    break;
                case (6):
                    Console.WriteLine("El numero que digitaste corresponde a Junio:  " + "= 6");
                    break;

                case (7):
                    Console.WriteLine("El numero que digitaste corresponde a Julio: " + "= 7");
                    break;

                case (8):
                    Console.WriteLine("El numero que digitaste corresponde a Agosto: " + "= 8");
                    break;

                case (9):
                    Console.WriteLine("El numero que digitaste corresponde a Septiembre:   "  +  " = 9"  );
                    break;

                case (10):
                    Console.WriteLine("El numero que digitaste corresponde a Octubre  " + "= 10" );
                    break;

                case (11):
                    Console.WriteLine("El numero que digitaste corresponde a Noviembre  " + "= 11");
                    break;

                case (12):
                    Console.WriteLine("El numero que digitaste corresponde a Diciembre  "  +  "= 12"   );
                    break;



                default:
                    Console.WriteLine(" No valido ,Digite un numero del 1 al 12");
                    break;

                    
            }
            Console.ReadKey();
        }
    }
}
