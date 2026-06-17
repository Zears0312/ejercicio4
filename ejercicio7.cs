using System;
class Program
{
    static void Main()
    {
    Console.WriteLine("1. Declarar array de 5 notas e imprimir cada una.");
        int[] notas = { 6, 9, 3, 2, 1};
        for(int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Nota: " + notas[i]);
        }
    Console.WriteLine("2. Calcular el promedio de un array de notas.");
    int[] notas2 = { 6, 9, 3, 2, 1};
    int suma = 0;
    for(int i = 0; i < notas2.Length; i++)
    {
        suma += notas2[i];
    
    }
    Console.WriteLine("El promedio es: " + (double)suma / notas2.Length);

    Console.WriteLine("3. Encontrar el maximo y minimo de un array.");
    int[] numeros = {6,9,3,10,8};
    int maximo=numeros[0];
    int minimo=numeros[0];
    foreach (int q in numeros)
    {
        if(q>maximo) maximo = q;
        if(q<minimo) minimo = q;
    }

    Console.WriteLine("4. Invertir un array sin usar metodos de .NET.");
    int[] notas3 = { 6, 9, 3, 2, 1};
    int[] notasInvertidas = new int[notas3.Length];
    for(int i = 0; i < notas3.Length; i++)
    {
        notasInvertidas[i] = notas3[notas3.Length - 1 - i];


    }
    Console.WriteLine("Array invertido:");
    for(int i = 0; i < notasInvertidas.Length; i++)
    {
        Console.WriteLine("Nota: " + notasInvertidas[i]);
        
    }
    Console.WriteLine("5. Contar cuantos elementos son mayores a 7.");
    int SonMayores = 0;
    int[] elementos = {5, 7, 10, 5, 3};
    for(int i = 0; i  < elementos.Length; i++)
        {
            if(elementos[i] > 7)
            {
                SonMayores++;
            }
        }
    //Elementos mayores que 7 son: " + SonMayores

    Console.WriteLine("6. Crear List<string> de tareas y agregar 3 items.");
    List<string> tareas = new List<string>();
    tareas.Add("Limpiar el piso");
    tareas.Add("Ordenar el cuarto");
    tareas.Add("Lavar los platos");
    foreach (string e in tareas)
        Console.WriteLine(e + " ");

    Console.WriteLine("7. Eliminar una tarea de la lista y verificar Count.");
    tareas.Remove("Lavar los platos");
    Console.WriteLine("Count: " + tareas.Count);

    Console.WriteLine("8. Recorrer la lista con foreach.");
    foreach (string y in tareas)
        Console.WriteLine(y + " ");

    Console.WriteLine("9. Crear array 2D 3x3 e imprimir la diagonal.");
    int[,] array2d = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 } };
    for (int i=0; i < 3; i++)
        {
            Console.WriteLine(array2d[i,i] + " ");
        }
    Console.WriteLine("10. Verificar si un elemento existe en el array con un bucle.");
    int[] array = {1,5,8,3,10,7,12};
    int verificar = 11;
    bool encontrado = false;
    for(int i=0; i < array.Length; i++)
        {
            if (array[i]==verificar){
            encontrado = true;
            break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine("El elemento ha sido encontrado");
        }
        else
        {
            Console.WriteLine("El elemento no ha sido encotrado.");
        }


}
}