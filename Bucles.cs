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
                        
                        break;
                    case 5:
                       
                        break;
                    case 6:
                       
                        break;
                    case 7:
                        
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
            Console.WriteLine("Multiplos de 3 desde el 1 al 100\n");

            for (int i = 3; i <= 100; i *= 3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void Ciclo2()
        {
            for (int i = 1; i <= 100; i += 1)
            {
                Console.WriteLine("Números impares desde 1 a 100\n"+i);
            }
            Console.ReadKey();
        }

        static void Ciclo3()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine("Números pares desde 1 a 100\n" + i);
            }
            Console.ReadKey();
        }

        static void Ciclo4()
        {
            double resul;
            Console.WriteLine("Ingrese el numero de euros que desea convertir");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            resul = valor1 * 0.94;
            Console.WriteLine("Euros = €" + valor1 + " Equivalen a $" + resul + " Dolares");
        }

        static void Ciclo5()
        {
            double resul1, resul2;
            Console.WriteLine("Ingrese un lado del cuadrado");
            double lad = Convert.ToDouble(Console.ReadLine());
            resul1 = Math.Pow(lad, 2);
            resul2 = lad * 4;
            Console.WriteLine("El area del cuadrado es: " + resul1);
            Console.WriteLine("El perimetro del cuadrado es: " + resul2);
        }

        static void Ciclo6()
        {
            double area, vol;
            Console.WriteLine("Ingrese el radio del cilindro");
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro");
            double altura = Convert.ToDouble(Console.ReadLine());
            vol = Math.PI * Math.Pow(rad, 2) * altura;
            area = (2 * (Math.PI) * rad * altura) + (2 * (Math.PI) * Math.Pow(rad, 2));
            Console.WriteLine("El volumen del cilindro es: " + vol);
            Console.WriteLine("El area del cilindro es: " + area);
        }

        static void Ciclo7()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            double circu = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("La longitud de la circunferencia es: " + circu);
            Console.WriteLine("El area del circulo es: " + area);
        }

    }
}