using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        double radio;
        Console.Write("Ingresa el radio del círculo: ");
        while (!double.TryParse(Console.ReadLine(), out radio))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            Console.Write("Ingresa el radio del círculo: ");
        }
        Console.WriteLine($"Área del círculo con radio {radio}: {CalcularAreaCirculo(radio)}");

        double ancho, altura;
        Console.Write("Ingresa el ancho del rectángulo: ");
        while (!double.TryParse(Console.ReadLine(), out ancho))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            Console.Write("Ingresa el ancho del rectángulo: ");
        }
        Console.Write("Ingresa la altura del rectángulo: ");
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            Console.Write("Ingresa la altura del rectángulo: ");
        }
        Console.WriteLine($"Perímetro del rectángulo de ancho {ancho} y altura {altura}: {CalcularPerimetroRectangulo(ancho, altura)}");

        List<int> numeros = new List<int>();
        Console.Write("Ingresa una serie de números separados por comas: ");
        string[] numerosStr = Console.ReadLine().Split(',');
        foreach (string numStr in numerosStr)
        {
            int num;
            if (int.TryParse(numStr.Trim(), out num))
            {
                numeros.Add(num);
            }
        }
        Console.WriteLine($"Promedio de la lista de números: {CalcularPromedio(numeros)}");

        int numero;
        Console.Write("Ingresa un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
            Console.Write("Ingresa un número entero: ");
        }
        Console.WriteLine($"El número {numero} es {(EsPar(numero) ? "par" : "impar")}");

        string cadena;
        Console.Write("Ingresa una cadena: ");
        cadena = Console.ReadLine();
        Console.WriteLine($"La cadena en mayúsculas es: {ConvertirMayusculas(cadena)}");
         static double DistanciaEntrePuntos(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }
        {
            Console.WriteLine("Ingrese el valor de n:");
            int n = int.Parse(Console.ReadLine());

            int suma = SumaNumerosNaturales(n);
            Console.WriteLine($"La suma de los primeros {n} números naturales es: {suma}");
        }
        {
            Console.WriteLine("Ingrese un número entero:");
            int n = int.Parse(Console.ReadLine());

            int factorial = Factorial(n);
            Console.WriteLine($"El factorial de {n} es: {factorial}");
        }
    }



    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    static double CalcularPerimetroRectangulo(double ancho, double altura)
    {
        return 2 * (ancho + altura);
    }

    static double CalcularPromedio(List<int> numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return (double)suma / numeros.Count;
    }

    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    static string ConvertirMayusculas(string cadena)
    {
        return cadena.ToUpper();
    }
    public static double DistanciaEntrePuntos(double x1, double y1, double x2, double y2)
    {
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distancia;
    }
    public static int SumaNumerosNaturales(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }
        return suma;
    }
    public static int Factorial(int n)
    {
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
