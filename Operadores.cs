using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Operadores
    {
        public void operadores()
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
                        triangulo();
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine();
                        suma();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        cuadrado();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        conversion();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        lados();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        radio();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        circunferencia();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        promedio();
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
        Variables variables = new Variables(0, 0, 0, 0);
        public void triangulo()
        {
            try
            {
                Console.WriteLine("Ingrese la base del triangulo");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                variables.dato3 = (variables.dato1 * variables.dato2) / 2;
                Console.WriteLine("El resultado es:" + variables.dato3);
            }
            catch (Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void suma()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.dato3 = Convert.ToDouble(Console.ReadLine());
                variables.dato1 = variables.dato2 + variables.dato3;
                Console.WriteLine("El resultado es:" + variables.dato1);
            }
            catch(Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void cuadrado()
        {
            try
            {
                Console.WriteLine("Ingrese el numero");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                variables.dato2 = variables.dato1 * variables.dato1;
                Console.WriteLine("El resultado es:" + variables.dato2);
            }
            catch (Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }    
        
        public void conversion()
        {
            try
            {
                Console.WriteLine("Ingrese el numero de euros que desea convertir");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                variables.dato2 = variables.dato1 * 0.94;
                Console.WriteLine("Euros = €" + variables.dato1 + " Equivalen a $" + variables.dato2 + " Dolares");
            }
            catch(Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void lados()
        {
            try
            {
                Console.WriteLine("Ingrese un lado del cuadrado");
                double lad = Convert.ToDouble(Console.ReadLine());
                variables.dato1 = Math.Pow(lad, 2);
                variables.dato2 = lad * 4;
                Console.WriteLine("El area del cuadrado es: " + variables.dato1);
                Console.WriteLine("El perimetro del cuadrado es: " + variables.dato2);
            }
            catch(Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void radio()
        {
            try
            {
                Console.WriteLine("Ingrese el radio del cilindro");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del cilindro");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                variables.dato3 = Math.PI * Math.Pow(variables.dato1, 2) * variables.dato2;
                variables.dato4 = (2 * (Math.PI) * variables.dato1 * variables.dato2) + (2 * (Math.PI) * Math.Pow(variables.dato1, 2));
                Console.WriteLine("El volumen del cilindro es: " + variables.dato3);
                Console.WriteLine("El area del cilindro es: " + variables.dato4);
            }
            catch(Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void circunferencia()
        {
            try
            {
                Console.WriteLine("Ingrese el radio del circulo");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                variables.dato2 = 2 * Math.PI * variables.dato1;
                variables.dato3 = Math.PI * Math.Pow(variables.dato1, 2);
                Console.WriteLine("La longitud de la circunferencia es: " + variables.dato2);
                Console.WriteLine("El area del circulo es: " + variables.dato3);
            }
            catch (Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }

        public void promedio()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.dato1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.dato2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero");
                variables.dato3 = Convert.ToDouble(Console.ReadLine());
                variables.dato4 = (variables.dato1 + variables.dato2 + variables.dato3) / 3;
                Console.WriteLine("El promedio de los tres numeros es: " + variables.dato4);
            }
            catch(Exception)
            {
                Console.WriteLine("EL DATO INGRESADO ES ERRONEO");
            }
        }
    }
}
