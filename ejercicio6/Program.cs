using System;
class Program
{
    static void Main()
    {
     //1. Imprimir los numeros del 1 al 20 con for.
     for(int i = 1;i <= 20;i++)
        {
            Console.WriteLine($"i: {i}");
        }
    //2. Imprimir solo los pares del 2 al 20.
    for(int s = 2; s <= 20; s += 2)
        {
            Console.WriteLine($"Par:  {s}");
        }
    //3. Calcular la suma de 1 a 100 con for.
    for(int e=1;e<=100; e++)
        {
            Console.WriteLine(e);
        }
    //4. Cuenta regresiva del 10 al 1 con while.
    int alto=10;
        while (alto == 1)
        {
            Console.WriteLine(alto--);
        }
    //5. Pedir al usuario un numero hasta que ingrese uno positivo (do-while).
        int numero;
        do
        {
            Console.Write(numero="Ingrese un numero positivo");
        }
         while (numero < 0);
        {
            Console.WriteLine("Numero no positivo");
        }
    //6. Imprimir tabla de multiplicar del 5.
    for(int tabla = 5; tabla<=50; tabla += 5)
        {
            Console.WriteLine($"Tabla del 5: {tabla}");
        }
    //7. Usar foreach para imprimir cada letra de un string.
    string[] letras = { "a","e","i","o","u"};
        foreach (string f in letras)
        {
            Console.WriteLine(f);
        }
    //8. Usar break para detener el bucle cuando se encuentra el numero 13.
            
     }

    }

