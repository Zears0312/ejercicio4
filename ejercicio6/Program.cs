using System;
class Program
{
    static void Main()
    {
     Console.WriteLine("1. Imprimir los numeros del 1 al 20 con for.");
     for(int i = 1;i <= 20;i++)
        {
            Console.WriteLine("i: " + i);
        }
    Console.WriteLine("2. Imprimir solo los pares del 2 al 20.");
    for(int s = 2; s <= 20; s += 2)
        {
            Console.WriteLine("Par: " + s);
        }
    Console.WriteLine("3. Calcular la suma de 1 a 100 con for.");
    for(int e=1;e<=100; e++)
        {
            Console.WriteLine(e);
        }
    Console.WriteLine("4. Cuenta regresiva del 10 al 1 con while.");
    int alto=10;
        while (alto >= 1)
        {
           Console.WriteLine(alto);
            alto--;
        }
    Console.WriteLine("5. Pedir al usuario un numero hasta que ingrese uno positivo (do-while).");
        int numero = 0;
        do
        {
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if(numero <= 0)
            {
                Console.WriteLine("Numero no positivo");
            }
        }
         while (numero <= 0);
        {
            Console.WriteLine("Numero positivo!");
        }
    Console.WriteLine("6. Imprimir tabla de multiplicar del 5.");
    for(int tabla = 5; tabla<=50; tabla += 5)
        {
            Console.WriteLine("Tabla del 5: " + tabla);
        }
    Console.WriteLine("7. Usar foreach para imprimir cada letra de un string.");
    string vocales = "aeiou";
    
        foreach (char f in vocales)
        {
            Console.WriteLine(f);
        }
    Console.WriteLine("8. Usar break para detener el bucle cuando se encuentra el numero 13.");
     for (int l = 1; l <= 20; l++)
        {
            Console.WriteLine("Numero agregado: " + l);
            if (l == 13)
            {
            
                Console.WriteLine("Se encontro el numero 13");
                break;
            }
        }
    Console.WriteLine("9. Usar continue para saltear multiplos de 3.");
     for (int b=1; b<=20; b++)
        {
            
            if(b % 3 ==0)
            {
                continue;
            }
            Console.WriteLine("Numeros agregados: " + b);
        }
    Console.WriteLine("10. Crear patron de asteriscos: 5 filas con bucles anidados.");
int filas = 5;

for (int p = 1; p <= filas; p++)
{
    for (int y = 1; y <= p; y++)
    {
        Console.Write("*");
    } 

    
    Console.WriteLine(); 

} 


Console.WriteLine("Presione una tecla para salir");
Console.ReadKey();
    }
    }
    

