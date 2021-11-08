using System;

namespace Operaciones_Aritméticas_Básicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Char opcion;
            String continuar;

            do
            {
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("|*                                                                           *|");
                Console.WriteLine("|*                   1. La suma de dos números               (x + y)         *|");
                Console.WriteLine("|*                   2. La resta de dos números              (x - y)         *|");
                Console.WriteLine("|*                   3. La multiplicación de dos números     (x * y)         *|");
                Console.WriteLine("|*                   4. La división de dos números           (x / y)         *|");
                Console.WriteLine("|*                   5. El residuo de la división            (x % y)         *|");
                Console.WriteLine("|*                   6. Todas las operaciones                                *|");
                Console.WriteLine("|*                                                                           *|");
                Console.WriteLine("|*                   0. Salir                                                *|");
                Console.WriteLine("|*                                                                           *|");
                Console.WriteLine("|------------------------------------------------------Feliz De Ayudar--------|");
                Console.Write("\n");
                Console.Write("Por favor inserte una opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '6');

                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El resultado de la suma es: " + op.opsuma().ToString());
                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El resultado de la resta es: " + op.opresta().ToString());
                        }
                        break;
                    case '3':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El resultado de la multiplicación es: " + op.opmultiplicar().ToString());
                        }
                        break;
                    case '4':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El resultado de la división es: " + op.opdivision().ToString());
                        }
                        break;
                    case '5':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El residuo de la división es: " + op.opresiduo().ToString());
                            Console.WriteLine("NOTA: El residuo es la cantidad que sobra luego de una división");
                        }
                        break;
                    case '6':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("------------------------------");

                            Console.Write("Por favor ingrese el primer número   (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Por favor ingrese el segundo número  (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------------");
                            Class1 op = new Class1(numeroX, numeroY);

                            Console.WriteLine("El resultado de la suma es                       : " + op.opsuma().ToString());
                            Console.WriteLine("El resultado de la resta es                      : " + op.opresta().ToString());
                            Console.WriteLine("El resultado de la multiplicación es             : " + op.opmultiplicar().ToString());
                            Console.WriteLine("El resultado de la división es                   : " + op.opdivision().ToString());
                            Console.WriteLine("El residuo de la división es                     : " + op.opresiduo().ToString());
                        }
                        break;
                }



                Console.WriteLine("-----");
                Console.Write("¿Quieres continuar? y/n");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");
        }


    }
    }

