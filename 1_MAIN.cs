using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class CLASE_MAIN
    {
       static void Main(string[] args)
        {
            int Elec;

            Operadores operadores = new Operadores();
            Condicionales condicionales = new Condicionales();
            Bucles bucles = new Bucles();
            Arreglos arreglos = new Arreglos();

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("----------MISCELANEA----------");
                Console.WriteLine("");
                Console.WriteLine(" 1. OPERADORES \n 2. CONDICIONALES" +
                    "\n 3. BUCLES \n 4. ARREGLOS \n 9. SALIR ");
                Console.WriteLine();
                Elec = Convert.ToInt32(Console.ReadLine());

                switch (Elec)
                {
                    case 1:
                        {
                            operadores.operadores();
                        }
                        break;

                    case 2:
                        {
                            condicionales.condicionales();
                        }
                        break;

                    case 3:
                        {
                            bucles.bucles();
                        }
                        break;

                    case 4:
                        {
                            // Arreglos();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("FINALIZANDO PROGRAMA");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("DIGITE UN VALOR QUE SEA CORRECTO");
                        }
                        break;
                }


            } while (Elec != 9);
            Console.ReadKey();
        }
        
    }

}