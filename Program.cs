//TAREA 7-8 ( 7 puntos de Calificación)

using System;
using System.Collections.Generic;

namespace ProgramNum
{
    class Program
    {
        public static void Main (string[]args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
          System.Console.WriteLine("BIENVENIDO USUARIO");
          Thread.Sleep(4000);
          Console.Clear();
          System.Console.WriteLine("ESTE PROYECTO SE LLEVA A CABO POR LA INSTITUCIÓN ITLA");
          Thread.Sleep(4000);
          Console.Clear();
          System.Console.WriteLine("PULSE ENTER PARA INICIAR");
          Console.ReadKey();
          Console.Clear();

          string respuesta;

          do
          {
            System.Console.WriteLine("Cual de los Temas de Ejercicio quiere ver: \n  \n1- USO DEL FOR \n2- USO DE LOS ARREGLOS");
            int ejercicio = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (ejercicio)
            {
                case 1: System.Console.WriteLine("Ha elejido el USO DEL FOR \n \n \n ¿Cual ejercicio Desea Usar? \n  \n1- Preguntar al usuario cuantos numeros va a introducir, pedirlos y mostrar la sumatoria de ellos.  \n \n2- Pedir dos numeros mostrar la secuencia descendente desde el numero mayor.  \n  \n3- Numeros Ascendentes y Descendentes.");
                int usofor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (usofor)
                {
                    case 1: System.Console.Write("Cuantos numero va a introducir: ");
                    int numeros = int.Parse(Console.ReadLine()!);
                    Console.Clear();

                    int positivo = 0;
                    int negativo = 0;

                    int[] Almacen = new int [numeros];

                    
                    for (int i = 0; i < numeros; i++)
                    {
                     System.Console.WriteLine("Inserte un numero: ");
                     Almacen [i] = int.Parse(Console.ReadLine()!);
                     Console.Clear();

                     if (Almacen[i] <= -1)
                     {
                        negativo = negativo + 1;
                     }
                     if (Almacen[i] >= 1)
                     {
                        positivo = positivo + 1;
                     }
                    }
                    System.Console.WriteLine("Los numeros introducidos Fueron: ");

                    for (int i = 0; i < Almacen.Length; i++)
                    {
                        System.Console.WriteLine(Almacen[i]);
                    }
                    System.Console.WriteLine(@"
                        ");
                    System.Console.WriteLine($"Usted ha introducido {numeros} numeros, {positivo} postivo y {negativo} negativo");
                    System.Console.WriteLine("\n \n \nPULSE ENTER PARA SALTAR LA PAGINA");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 2: System.Console.WriteLine("USTED TENDRA QUE INTRODUCIR DOS NUMEROS \n \nIntroduzca el 1er numero");
                    int num1 = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    System.Console.WriteLine("Introduzca el 2do numero");
                    int num2 = int.Parse(Console.ReadLine()!);
                    Console.Clear();

                    if (num1 > num2)
                    {
                        System.Console.WriteLine($"El 1er digito ({num1}) es mayor que el 2do digito ({num2}) \nDe forma Descendente.");
                        System.Console.WriteLine("");

                        for (int i = num1; i >= num2; i--){
                            System.Console.WriteLine("{0}|", i);
                        }
                    }
                    else if (num2 > num1)
                    {
                        System.Console.WriteLine($"El 2do digito ({num2}) es mayor que el 1er digito ({num1}) \nDe forma Descendente:");

                        for (int i = num2; i >= num1; i--)
                        {
                            System.Console.WriteLine("{0}|", i);
                        }
                    }
                    System.Console.WriteLine("");
                    break;

                    case 3: System.Console.Write("Escriba un numero Aleatorio: ");
                            int Aleatorio = int.Parse(Console.ReadLine()!);
                            Console.Clear();
                            System.Console.Write("¿Cual es su Nombre? ");
                            string Nombre = Console.ReadLine()!;
                            Console.Clear();
                            System.Console.WriteLine("¿Cual es su Matricula Universitaria? ");
                            string Matricula = Console.ReadLine()!;
                            Console.Clear();

                            if (Aleatorio > 10)
                            {
                                if (Aleatorio % 2 == 1)
                                {
                                    System.Console.WriteLine($"El numero introducido ({Aleatorio}) es Impar.  \n \n Estos son los numeros del 100 al 500 de forma Ascendentes de 10 en 10   \n ");
        
                                    for (int i = 100; i <= 500; i=i+10)
                                    {
                                        System.Console.WriteLine("{0}|", i);
                                    }
                                }
                            }

                            if (Aleatorio > 10)
                            {
                                if (Aleatorio % 2 == 0)
                                {
                                    System.Console.WriteLine($"El numero introducido ({Aleatorio}) es Par. \n \nEn breve le mostraremos un saludo 5 veces: \n");

                                    for (int i = 1; i <=5; i++)
                                    {
                                        System.Console.WriteLine($"Hola {Nombre}, ¿Que tal tu dia?");
                                    }
                                    System.Console.WriteLine("");
                                }
                            }
                            
                            if (Aleatorio <=10)
                            {
                                System.Console.WriteLine("Nombre | Matricula");
                                for (int i = 1; i <= 15; i++)
                                {
                                    System.Console.WriteLine("-------------------" + (i) + "--------------------");
                                    System.Console.WriteLine(Nombre+"  | "+ Matricula + "\n ");
                                }
                                System.Console.WriteLine(""); 
                            }
                        break;
                    
                    default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DEL RANDO DE 1-3");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                break;

                case 2: System.Console.WriteLine("Ha elejido EL USO DE LOS ARREGLOS \n \n¿Cual ejercicio desea usar? \n \n1- Pedir 5 numeros y sumarlos. \n2- Recibir 7 numeros y verificar sí esta el 23. \n3- Recibir 10 numeros y sacar los Pares e Impares \n4- Recibir 5 numeros y ponerlos en un segundo arreglo.");
                int arreglos = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (arreglos)
                {
                    case 1:
                    int [] FiveNum = new int [5];

                    for (int i = 0; i <= 4; i++)
                    {
                        System.Console.Write("Introduzca un numero: ");
                        FiveNum[i] = Convert.ToInt32(Console.ReadLine()!);
                        Console.Clear();
                    }

                    System.Console.WriteLine("Los numeros ingresados fueron: ");
                    for (int i = 0; i < FiveNum.Length; i++)
                    {
                        System.Console.WriteLine(FiveNum[i]);
                    }
                    int suma = 0;
                   foreach (int item in FiveNum)
                   {
                    suma += item;
                   }

                    System.Console.WriteLine($" \nLa sumatoria de todos los numeros es: {suma} \n ");

                    break;
                    
                    default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DEL RANGO DE 1-4");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 2:
                    System.Console.WriteLine("¿Cual es el nombre del usuario?");
                    string Nombre = Console.ReadLine()!;
                    int [] SevenNum = new int [7];
                    Boolean Existe = false;

                    for (int i = 0; i <= 6; i++)
                    {
                        System.Console.Write("A continuacion usted debera ingresar 7 numeros. \n \nIntroduzca un numero: ");
                        SevenNum[i] = int.Parse(Console.ReadLine()!);
                        Console.Clear();
                    }
                    
                    System.Console.WriteLine("Los numeros Introducidos fueron: \n");
                    for (int i = 0; i < SevenNum.Length; i++)
                    {
                        System.Console.WriteLine(SevenNum[i]);
                    }
                    System.Console.WriteLine("");

                    for (int i = 0; i < SevenNum.Length; i++)
                    {
                        if (SevenNum[i] == 23)
                        {
                            Existe = true;
                        }
                    }

                    if (Existe)
                    {
                        System.Console.WriteLine($"Hola {Nombre}, El numero 23 sí se encuentra en la lista. ¿Que tal tu dia {Nombre} :)?");
                    }

                    else
                    {
                        System.Console.WriteLine($"Los sentimos :( {Nombre}, El numero 23 no se encuentra en la Lista. \n Pase Buenas!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3: System.Console.WriteLine("A continuacion ingrese 10 numeros... \n");

                    int[] TenNum = new int [10];

                    int Par = 0;
                    int Impar = 0;

                    for (int i = 0; i <=9; i++)
                    {
                        System.Console.Write("Ingrese un numero: ");
                        TenNum[i] = int.Parse(Console.ReadLine()!);
                        Console.Clear();
                    
                        if (TenNum[i] % 2 == 0)
                        {
                         Par = Par + 1;
                        }
                        
                        if (TenNum[i] % 2 == 1)
                        {
                            Impar = Impar + 1;
                        }
                    }

                    int[] Pares = new int [Par];
                    int[] Impares = new int [Impar];

                    Par = 0;
                    Impar = 0;

                     for (int i = 0; i <=9; i++)
                     {
                        if (TenNum[i] % 2 == 0)
                        {
                         Pares[Par] = TenNum[i];
                         Par++;
                        }
                     }

                    for (int i = 0; i <=9; i++)
                    {
                        if (TenNum[i] % 2 == 1)
                        {
                            Impares[Impar] = TenNum[i];
                            Impar++;
                        }
                    }
                    System.Console.WriteLine($"Has insertado {Par} numeros Par y {Impar} numeros Impar.");

                    System.Console.Write("\nNumeros Pares: ");
                    for (int i = 0; i < Par; i++)
                    {
                        System.Console.Write(Pares[i] + "|");
                    }

                    System.Console.Write("\n \nNumeros Impares: ");
                    for (int i = 0; i < Impar; i++)
                    {
                        System.Console.Write(Impares[i] + "|");
                    }
                    System.Console.WriteLine("\n");
                    break;

                    case 4: System.Console.Write("A Continuacion introduzca 5 numeros. \n");

                    int [] fiveNum = new int [5];
                    int [] fivenum2 = new int [5];
                    int iguales = 0;

                    for (int i = 0; i <= 4; i++)
                    {
                        System.Console.Write("Introduzca un numero: ");
                        fiveNum[i] = int.Parse(Console.ReadLine()!);
                        Console.Clear();

                        if (fiveNum[i] % 2 == 0)
                        {
                            iguales = iguales + 1;
                            fiveNum[i] = fiveNum[i] * 10;
                        }

                        fivenum2 [i] = fiveNum[i]; 
                    }
                   
                   System.Console.Write($"Hay {iguales} numeros pares. \n");

                    for (int i = 0; i < fivenum2.Length; i++)
                    {
                        System.Console.Write(fivenum2[i] + " | ");    
                    }
                    System.Console.WriteLine("\n");
                    break;
                }
                break;
                
                default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DEL RANGO"); 
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
                Console.Clear();
                break;
          }
            System.Console.WriteLine("¿Quiere reptir el programa?");
            respuesta = Console.ReadLine()!;
            Console.Clear();
        } while (respuesta != "no");
          System.Console.WriteLine("GRACIAS POR USAR NUESTRO PROGRAMA");
          Thread.Sleep(3000);
          Console.Clear();
          System.Console.WriteLine("ITLA - INSTITUTO TECNOLOGICO DE LAS AMERICAS");
    }  
  }
}