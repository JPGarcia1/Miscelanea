using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Bucles
    {
        public static void bucles()
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
        static void Ciclo1()
        {
            Console.WriteLine("Multiplos de 3 desde el 1 al 100");

            for (int i = 3; i <= 100; i *= 3)
            {
                Console.Write(i);
                Console.WriteLine("\n");
            }
        }
        static void Ciclo2()
        {
            Console.WriteLine("Números impares desde 1 a 100\n");
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(i);
                    Console.Write("~");
                }
            }
            Console.WriteLine("\n");
        }
        static void Ciclo3()
        {
            Console.WriteLine("Números pares desde 1 a 100");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i);
                Console.Write("~");
            }
            Console.WriteLine("\n");
        }
        static void Ciclo4()
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("\nCuadrado del " + i + " : " + (i * i));
            }
        }

        static void Ciclo5()
        {
            int i, suma;
            suma = 0;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine("\nCuadrado del " + i + " : " + (i * i));
                suma = suma + i * i;
                Console.WriteLine();
            }
            Console.WriteLine("TOTAL: " + suma + "\n");
        }
        static void Ciclo6()
        {
            Console.WriteLine("Ingrese el número menor");
            int menor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número mayor");
            int mayor = Convert.ToInt32(Console.ReadLine());

            if (menor < mayor)
            {
                for (int i = menor; i <= mayor; i++)
                {
                    Console.WriteLine("\n" + i);
                }
            }
            else
            {
                Console.WriteLine("\nPor favor ingrese bien el primer número menor");
            }
        }
        static void Ciclo7()
        {
            int x;
            int sum = 0;

            Console.WriteLine("Ingrese los numeros\nPresione 0 para cerrar la suma");
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum = x + sum;

                if (x != 0)
                    Console.WriteLine(sum);
            }
            while (x != 0);

            Console.WriteLine("Terminado");
        }

    }
}