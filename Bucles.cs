using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Bucles
    {
        public void bucles()
        {
            int ElecBu;

            do
            {
                Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                Console.WriteLine(" 1. Multiplos del 3 desde el 1 al 100 \n 2. Números impares entre 0 y 100. \n 3. Números pares entre 0 y 100. " +
                    "\n 4. Números cuadrados del 1 al 30. \n 5. Suma de todos los cuadrados del 1 al 100. " +
                    "\n 6. Lista de números elegidos. \n 7. Sumar todos los números digitados por teclado.");

                Console.WriteLine(" 9. SALIR");

                ElecBu = Convert.ToInt32(Console.ReadLine());

                switch (ElecBu)
                {
                    case 1:
                        Ciclo1();
                        break;
                    case 2:
                        Ciclo2();
                        break;
                    case 3:
                        Ciclo3();
                        break;
                    case 4:
                        Ciclo4();
                        break;
                    case 5:
                        Ciclo5();
                        break;
                    case 6:
                        Ciclo6();
                        break;
                    case 7:
                        Ciclo7();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        {
                            Console.WriteLine("Opcion no válida");
                        }
                        break;
                }
            } while (ElecBu != 9);

            Console.ReadKey();
        }
        Variables variables = new Variables(0, 0, 0, 0, 0);
        public void Ciclo1()
        {
                Console.WriteLine("Multiplos de 3 desde el 1 al 100");

                for (variables.dato1 = 3; variables.dato1 <= 100; variables.dato1 *= 3)
                {
                    Console.Write(variables.dato1);
                    Console.WriteLine("\n");
                }
        }
        public void Ciclo2()
        {
             Console.WriteLine("Números impares desde 1 a 100\n");
             for (variables.dato1 = 1; variables.dato1 <= 100; variables.dato1++)
             {
                 if (variables.dato1 % 2 != 0)
                 {
                     Console.Write(variables.dato1);
                     Console.Write("~");
                 }
             }
             Console.WriteLine("\n");
        }
        public void Ciclo3()
        {
            Console.WriteLine("Números pares desde 1 a 100");
            for (variables.dato1 = 1; variables.dato1 <= 100; variables.dato1 += 2)
            {
                Console.Write(variables.dato1);
                Console.Write("~");
            }
            Console.WriteLine("\n");
        }
        public void Ciclo4()
        {
            for (variables.dato1 = 1; variables.dato1 <= 30; variables.dato1++)
            {
                Console.WriteLine("\nCuadrado del " + variables.dato1 + " : " + (variables.dato1 * variables.dato1));
            }
        }
        public void Ciclo5()
        {
            variables.dato1 = 0;
            for (variables.dato2 = 1; variables.dato2 <= 100; variables.dato2++)
            {
                Console.WriteLine("\nCuadrado del " + variables.dato2 + " : " + (variables.dato2 * variables.dato2));
                variables.dato1 = variables.dato1 + variables.dato2 * variables.dato2;
                Console.WriteLine();
            }
            Console.WriteLine("TOTAL: " + variables.dato1 + "\n");
        }
        public void Ciclo6()
        {
            try
            {
                Console.WriteLine("Ingrese el número menor");
                variables.dato1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número mayor");
                variables.dato2 = Convert.ToInt32(Console.ReadLine());

                if (variables.dato1 < variables.dato2)
                {
                    for (variables.dato3 = variables.dato1; variables.dato3 <= variables.dato2; variables.dato3++)
                    {
                        Console.WriteLine("\n" + variables.dato3);
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor ingrese bien el primer número menor");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El caracter ingresado es erroneo");
            }
        }
        public void Ciclo7()
        {
            try
            {
                Console.WriteLine("Ingrese los numeros\nPresione 0 para cerrar la suma");
                do
                {
                    variables.dato1 = Convert.ToInt32(Console.ReadLine());
                    variables.dato2 = variables.dato1 + variables.dato2;

                    if (variables.dato1 != 0)
                        Console.WriteLine(variables.dato2);
                }
                while (variables.dato1 != 0);

                Console.WriteLine("Terminado");
            }
            catch(Exception)
            {
                Console.WriteLine("El caracter ingresado es erroneo");
            }
        }
    }
}