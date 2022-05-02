using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Operadores
    {
        public static void operadores()
        {
            int ElecOp;

            do
            {


                Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                Console.WriteLine(" 1. Area de un triángulo");
                Console.WriteLine(" 2. Suma de dos números");
                Console.WriteLine(" 3. Cuadrado de un número");
                Console.WriteLine(" 4. Conversión de euros a dólares");
                Console.WriteLine(" 5. Area y perimetro de un cuadrado a partir de un de sus lados");
                Console.WriteLine(" 6. Area y volumen de un cilindro");
                Console.WriteLine(" 7. Longitud y area de un circulo a partir de su radio");
                Console.WriteLine(" 8. Promedio de tres numeros");
                Console.WriteLine(" 9. SALIR");

                ElecOp = Convert.ToInt32(Console.ReadLine());


                switch (ElecOp)
                {
                    case 1:
                        Console.WriteLine();
                        TRIANGULO();
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine();
                        SUMA();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        CUADRADO();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        CONVERSION();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        LADOS();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        RADIO();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        CIRCUNFERENCIA();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        PROMEDIO();
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

            } while (ElecOp != 9);

            Console.ReadKey();
        }

        static void TRIANGULO()
        {
            double resul;
            Console.WriteLine("Ingrese la base del triangulo");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            double alt = Convert.ToDouble(Console.ReadLine());
            resul = (bas * alt) / 2;
            Console.WriteLine("El resultado es:" + resul);
        }

        static void SUMA()
        {
            double resul;
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            resul = num1 + num2;
            Console.WriteLine("El resultado es:" + resul);
        }

        static void CUADRADO()
        {
            double resul;
            Console.WriteLine("Ingrese el numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            resul = num1 * num1;
            Console.WriteLine("El resultado es:" + resul);
        }

        static void CONVERSION()
        {
            double resul;
            Console.WriteLine("Ingrese el numero de euros que desea convertir");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            resul = valor1 * 0.94;
            Console.WriteLine("Euros = €" + valor1 + " Equivalen a $" + resul + " Dolares");
        }

        static void LADOS()
        {
            double resul1, resul2;
            Console.WriteLine("Ingrese un lado del cuadrado");
            double lad = Convert.ToDouble(Console.ReadLine());
            resul1 = Math.Pow(lad, 2);
            resul2 = lad * 4;
            Console.WriteLine("El area del cuadrado es: " + resul1);
            Console.WriteLine("El perimetro del cuadrado es: " + resul2);
        }

        static void RADIO()
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

        static void CIRCUNFERENCIA()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            double circu = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("La longitud de la circunferencia es: " + circu);
            Console.WriteLine("El area del circulo es: " + area);
        }

        static void PROMEDIO()
        {
            double resul1;
            Console.WriteLine("Ingrese el primer numero");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            double numero3 = Convert.ToDouble(Console.ReadLine());
            resul1 = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("El promedio de los tres numeros es: " + resul1);
        }
        Operadores op = new Operadores();
    }
}
