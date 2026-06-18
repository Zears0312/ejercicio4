using System;
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
        int sum = Sumar(5,10);
        Console.WriteLine("3. Crear metodo EsPar(int n) que retorne bool.");
        static bool EsPar(int n){
             
            if(n% 2 == 0){
             return true;
            }else{
                return false;
            }
        }
        Console.WriteLine("Su numero es par:" + EsPar(6));

        Console.WriteLine("4. Crear metodo Mayor(int a, int b) que retorne el mayor.");
        
        Console.WriteLine("5. Crear metodo CalcularFactorial(int n) con bucle.");
        Console.WriteLine("6. Crear metodo con valor por defecto en parametro.");
        Console.WriteLine("7. Demostrar scope: variable declarada en metodo no existe afuera.");
        Console.WriteLine("8. Crear metodo ImprimirArray(int[] arr) que muestre todos los elementos.");
        Console.WriteLine("9. Crear metodo ContarPares(int[] arr) que retorne cuantos pares hay.");
        Console.WriteLine("10. Separar el codigo del ejercicio anterior en 3 metodos distintos.");
    }
}