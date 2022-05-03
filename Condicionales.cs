using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Condicionales
    {
        public static void condicionales()
        {
            int ElecCon;

            do
            {


                Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                Console.WriteLine(" 1. Determinar si el numero es positivo. \n 2. Determinar número mayor o menor. \n 3. Imprimir número mayor y menor. " +
                    "\n 4. Si A es mayor que B, sumar, sino, restar. \n 5. Realizar una division y enunciar si no es posible " +
                    "\n 6. Sumar A y B, y multiplicar si uno es negativo. \n 7. Definir año bisiesto.");
                Console.WriteLine(" 9. SALIR");

                ElecCon = Convert.ToInt32(Console.ReadLine());


                switch (ElecCon)
                {
                    case 1:
                        Console.WriteLine();
                        Punto1();
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine();
                        Punto2();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        Punto3();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        
                        Console.WriteLine();
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

            } while (ElecCon != 9);

            Console.ReadKey();
        }

        static void Punto1()
        {
            float num;

            Console.Write("Ingrese número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.Write("El numero digitado {0} es cero", num);
            }


            if (num > 0)
            {
                Console.Write("El numero {0} es positivo", num);
            }

            if (num < 0)
            {
                Console.Write("El numero {0} es negativo", num);
            }

            Console.ReadKey();
        }


        static void Punto2()
        {
            int ma = 0, me = 0, num = 0;
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }



                num = 0;
            }

            Console.WriteLine(" numero mayor es: " + ma);
            Console.WriteLine(" numero menor es: " + me);

        }


        static void Punto3()
        {
            int ma = 0, me = 0, num = 0;
            Console.WriteLine("Ingrese 3 numeros enteros");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite el número " + i + ":");
                num = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }



                num = 0;
            }

            Console.WriteLine(" numero mayor es: " + ma);
            Console.WriteLine(" numero menor es: " + me);
        }

    }
}
