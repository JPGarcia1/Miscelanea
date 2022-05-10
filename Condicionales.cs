using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Condicionales
    {
        public void condicionales()
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
                        Punto4();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        Punto5();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        Punto6();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        Punto7();
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
        Variables variables = new Variables(0, 0, 0, 0, 0);
        public void Punto1()
        {
            Console.Write("Ingrese número:");
            variables.dato1 = Convert.ToInt32(Console.ReadLine());

            if (variables.dato1 == 0)
            {
                Console.Write("El numero digitado {0} es cero", variables.dato1);
            }


            if (variables.dato1 > 0)
            {
                Console.Write("El numero {0} es positivo", variables.dato1);
            }

            if (variables.dato1 < 0)
            {
                Console.Write("El numero {0} es negativo", variables.dato1);
            }

            Console.ReadKey();
        }


        public void Punto2()
        {
            Console.WriteLine("Cuantos numeros va ingresar");
            variables.dato1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= variables.dato1; i++)
            {
                Console.WriteLine("Digite un número: ");
                variables.dato2 = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    variables.dato3 = variables.dato2;
                    variables.dato4 = variables.dato2;
                }
                if (variables.dato2 > variables.dato3) { variables.dato3 = variables.dato2; }
                if (variables.dato2 < variables.dato4) { variables.dato4 = variables.dato2; }



                variables.dato2 = 0;
            }

            Console.WriteLine(" numero mayor es: " + variables.dato3);
            Console.WriteLine(" numero menor es: " + variables.dato4);

        }


        public void Punto3()
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
        public void Punto4()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                if (variables.dato1 < variables.dato2)
                {
                    variables.dato3 = variables.dato2 + variables.dato1;
                    Console.WriteLine($"{variables.dato1} + {variables.dato2} = {variables.dato3}");
                }
                else
                {
                    variables.dato3 = variables.dato1 - variables.dato2;
                    Console.WriteLine($"{variables.dato1} - {variables.dato2} = {variables.dato3}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");
            }


        }

        public void Punto5()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                if (variables.dato2 != 0)
                {
                    variables.dato3 = variables.dato1 / variables.dato2;
                    Console.WriteLine($"{variables.dato1} / {variables.dato2} = {variables.dato3}");
                }
                else
                {
                    Console.WriteLine("La división no es posible");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor que sea correcto");
            }

        }

        public void Punto6()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                if (variables.dato1 < 0 || variables.dato2 < 0)
                {
                    variables.dato3 = variables.dato1 + variables.dato2;
                    Console.WriteLine($"{variables.dato1} + {variables.dato2} = {variables.dato3}");
                }
                else
                {
                    variables.dato3 = variables.dato1 * variables.dato2;
                    Console.WriteLine($"{variables.dato1} * {variables.dato2} = {variables.dato3}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
                Console.ReadKey();
            }

        }

        public void Punto7()
        {
            try
            {
                Console.WriteLine("Ingrese el año");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());

                if (variables.dato1 % 4 == 0 && variables.dato1 % 100 != 0 || variables.dato1 % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto {0}\n", variables.dato1);
                }
                else
                {
                    Console.WriteLine("no es bisiesto {0} \n", variables.dato1);
                }
            }
            catch (FormatException)
            {
            }
        }
    }
}