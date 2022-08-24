using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_C
{
    internal class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static int Afahrenheit(int a)
        {
            return 5*(a - 32) / 9;
        }
        static int Acelcius(int a)
        {
            return a * 9 / 5 + 32; ;
        }

        static void Primos()
        {
            for (int x = 2; x < 30; x++)
            {
                int esPrimo = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        esPrimo++;

                    if (esPrimo == 2) break;
                }
                if (esPrimo != 2)
                    Console.WriteLine(x);

                esPrimo = 0;
            }
        }

        static void Raiz()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y Funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==========================================================");
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 prim. numeros ent.");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Division de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir a una temperatura Fahrenheit a Celcius");
                Console.WriteLine("[8] Convertir a una temperatura Celcius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese a una opción y presione ENTER");
                Console.WriteLine("==========================================================");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Sumando:");
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Resta:");
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Multiplicacion:");
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} por {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Division:");
                        Console.WriteLine("Ingrese el primer número");
                        int w = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} entre {1} es {2}", w, z, Division(w, z));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los Numeros Primos Son...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("FAHRENHEIT A CELSIUS:");
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0}º Fahrenheit a Celcius es {1}º", p, Afahrenheit(p));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("CELSIUS A FAHRENHEIT:");
                        Console.WriteLine("Ingrese la temperatura en Celcius");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0}º Celcius a Fahrenheit es {1}º", y, Acelcius(y));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}
