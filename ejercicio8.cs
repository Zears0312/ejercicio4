using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("1. Crear metodo Saludar(string nombre) que imprima mensaje.");
        
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("2. Crear metodo Sumar(int a, int b) que retorne la suma.");
        Console.WriteLine("3. Crear metodo EsPar(int n) que retorne bool.");
        Console.WriteLine("4. Crear metodo Mayor(int a, int b) que retorne el mayor.");
        Console.WriteLine("5. Crear metodo CalcularFactorial(int n) con bucle.");
        Console.WriteLine("6. Crear metodo con valor por defecto en parametro.");
        Console.WriteLine("7. Demostrar scope: variable declarada en metodo no existe afuera.");
        Console.WriteLine("8. Crear metodo ImprimirArray(int[] arr) que muestre todos los elementos.");
        Console.WriteLine("9. Crear metodo ContarPares(int[] arr) que retorne cuantos pares hay.");
        Console.WriteLine("10. Separar el codigo del ejercicio anterior en 3 metodos distintos.");
    }
}