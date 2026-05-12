using System;

class Program
{
    static void Main()
    {
        //1. Calcular el area de un rectangulo (base * altura).
        int altura = 10;
        int Base= 3;
        int area = altura * Base;
        Console.WriteLine($"Valor de area: {area}");
        //2. Calcular el resto de 100 dividido 7 con %.
        int c = 100;
        int resto = c%7;
        Console.WriteLine($"Resto: {resto}");
        //3. Convertir temperatura de Celsius a Fahrenheit: F = C * 9/5 + 32.
        int temp=30;
        int fahrenheit = temp * 9/5 + 32;
        Console.WriteLine($"celsius a fahrenheit: {fahrenheit}");
        //4. Usar int.Parse para convertir un string numerico.
        string entrada = "50";
        int numero = int.Parse(entrada);
        Console.WriteLine($"string a int: {numero}");
        //5. Usar double.TryParse y manejar el caso donde falla.
        string pi = "3.14";
        double pi2;
        bool H = double.TryParse(pi, out pi2);
        if (H)
        {
           Console.WriteLine($"Conversión exitosa: {pi2}"); 
        }
        else
        {
            Console.WriteLine("La cadena no es un número válido.");
        }
        //6. Calcular precio final con IVA (precio * 1.21).
        int precio = 5000;
        double precioFinal= precio * 1.21;
        Console.WriteLine($"Precio final: {precioFinal}");
        //7. Demostrar diferencia entre division entera (int/int) y real (double).
        int k = 10;
        int k2 = 5;
        int resultado = k/k2;
        int k3 = 3; 
        double resultado2= k/k3;
        Console.WriteLine($"division entera: {resultado}");
        Console.WriteLine($"division real: {resultado2}");
        //8. Usar ++ para incrementar un contador en un solo paso.
        int contador = 10;
        contador = contador++;
        Console.WriteLine($"contador: {contador}");
        //9. Convertir double a int con cast explicito (int).
        double doble = 9.50;
        int noDoble = (int)doble;
        Console.WriteLine($"double a int: {noDoble}");
        //10. Calcular cuantos dias completos hay en 1000 horas.
        int horas = 1000;
        int resultado3  = horas/24;
        Console.WriteLine ($"En {horas} hay {resultado3} dias");
}
    }
