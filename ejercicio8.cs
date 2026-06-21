using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.WriteLine("1. Crear metodo Saludar(string nombre) que imprima mensaje.");
        static void Saludar(string nombre){
            Console.WriteLine("Hola " + nombre);
        }
        Saludar("Felipe");
        Console.WriteLine("2. Crear metodo Sumar(int a, int b) que retorne la suma.");
        static int Sumar(int a, int b){
            int resultado = a + b;
            return resultado;
        }
        Console.WriteLine("La suma es: " + Sumar(5,10));

        Console.WriteLine("3. Crear metodo EsPar(int n) que retorne bool.");
        static bool EsPar(int n)
        {
            bool par= false;
            if(n % 2 == 0)
            {
                par = true;
            }
            else
            {
                par = false;
            }
            return par;
        }
    if (EsPar(5) == true)
    {
        Console.WriteLine("Es par");
    }
    else
    {
        Console.WriteLine("Es impar");
    }
        Console.WriteLine("4. Crear metodo Mayor(int a, int b) que retorne el mayor.");
        static int EsMayor(int a, int b)
        {
            if (a>b)
            {
                return a;
            }else{
                return b;
            }
        }
        Console.WriteLine("Su numero mayor es: " + EsMayor(10,6));

        Console.WriteLine("5. Crear metodo CalcularFactorial(int n) con bucle.");
        static int CalcularFactorial(int n)
        {
            int factorial = 1;
            for(int i = 1; i<=n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        Console.WriteLine(CalcularFactorial(5));

        Console.WriteLine("6. Crear metodo con valor por defecto en parametro.");
        static bool Division(int n, int divisor = 2)
        {
            bool par= false;
            if(n % divisor == 0)
            {
                par = true;
            }
            else
            {
                par = false;
            }
            return par;
        }
        Console.WriteLine("es par? " + Division(6));

        Console.WriteLine("7. Demostrar scope: variable declarada en metodo no existe afuera.");

        Console.WriteLine("8. Crear metodo ImprimirArray(int[] arr) que muestre todos los elementos.");
        static void ImprimirArray(int[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        ImprimirArray([10,5,30,2]);
        Console.WriteLine("9. Crear metodo ContarPares(int[] arr) que retorne cuantos pares hay.");
        static int ContarPares(int[] arr)
        {
            int contador = 0;
            foreach(int n in arr)
            {
                if (n % 2 == 0)
                {
                    contador ++;
                }
                
            }
            return contador;
        
        }
        Console.WriteLine("En este array hay " + ContarPares([10,5,6,30,2]) + " pares");

        Console.WriteLine("10. Separar el codigo del ejercicio anterior en 3 metodos distintos.");
        static bool ComprobacionPar(int n)
        {
            return n % 2== 0;

        }
        
        static int ContarPares2(int [] arr)
        {
        int contador = 0;
            foreach (int y in arr)
            {
                if (ComprobacionPar(y))
                {   
                    contador++;
                }
            
            }
        return contador;
        }
    static void resultado(int cantidad)
    {
        Console.WriteLine("Este array tiene " + cantidad + " pares");
    }
    resultado(ContarPares2([10,5,2,12,31]));
    }
}
