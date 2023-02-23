using System;


//ejercicio no1. 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos años tienes? ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("No aparentas {0} años", edad);
    }
}

//ejercicio no2.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el primer número (de dos cifras): ");
        byte numero1 = byte.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número (de dos cifras): ");
        byte numero2 = byte.Parse(Console.ReadLine());

        ushort resultado = (ushort)(numero1 * numero2);

        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
    }
}

//ejercicio no3.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el primer número: ");
        long numero1 = long.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        long numero2 = long.Parse(Console.ReadLine());

        long suma = numero1 + numero2;
        long resta = numero1 - numero2;
        long producto = numero1 * numero2;

        Console.WriteLine("La suma de los dos números es: {0}", suma);
        Console.WriteLine("La resta de los dos números es: {0}", resta);
        Console.WriteLine("El producto de los dos números es: {0}", producto);
    }
}