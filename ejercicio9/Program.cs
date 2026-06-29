using System;

class Program
{
    static void Main()
{  
    Console.WriteLine("1. Leer nombre y apellido por separado e imprimir juntos.");
    Console.Write("Escriba su nombre: ");
    string nombre = Console.ReadLine()!;
    Console.Write("Ingrese su apellido: ");
    string apellido = Console.ReadLine()!;
    Console.WriteLine("Hola " + nombre + " " + apellido);

    Console.WriteLine("2. Leer una oracion y contar cuantas letras tiene (sin espacios).");
    string oracion = "El sol brilla en el cielo";
    
    int contador = 0;
    foreach(char letras in oracion)
        {
            if(letras != ' ')
            {
                contador++;
            }
        }
        Console.WriteLine("Su oracion contiene: "+ contador + " letras");

    Console.WriteLine("3. Convertir texto a mayusculas y luego a minusculas.");
    string texto = "Hola mundo";
    Console.WriteLine("Normal: " + texto);
    texto = texto.ToUpper();
    Console.WriteLine("Mayuscula: " + texto);
    texto = texto.ToLower();
    Console.WriteLine("Minuscula: " + texto);

    Console.WriteLine("4. Verificar si una palabra ingresada contiene la letra 'a'.");
    Console.Write("Ingrese una palabra: ");
    string palabra = Console.ReadLine()!;
    int contador2 = 0;
    foreach(char a in palabra)
        {
            if(a == 'a')
            {
                contador2++;
            }
        }
    Console.WriteLine("Cantidad de 'a': " + contador2);

    Console.WriteLine("5. Reemplazar todos los espacios de una frase por guiones.");
    string frase = "No hay caminos para la paz, la paz es el camino";
    frase = frase.Replace(' ', '-');
    Console.WriteLine(frase);

    Console.WriteLine("6. Separar una frase en palabras con Split e imprimir cada una.");
    string frase2 = "Hola mundo";
    string[] palabras = frase2.Split(' ');
    foreach (string u in palabras)
        {
            Console.WriteLine(u);
        }

    Console.WriteLine("7. Verificar si dos strings son iguales ignorando mayusculas.");
    string mayus = "HOLA MUNDO";
    string minus = "hola mundo";
    if (mayus.ToLower() == minus.ToLower())
        {
            Console.WriteLine("Son iguales");
        }
        
    Console.WriteLine("8. Leer un numero como string y convertirlo a int con int.Parse.");
    Console.Write("Ingrese numero: ");
    string numero3 = Console.ReadLine()!;
    int numero = int.Parse(numero3);
    Console.WriteLine(numero);

    Console.WriteLine("9. Crear un 'formulario' que pida nombre, edad y ciudad.");
    Console.WriteLine("           Formulario");
    Console.Write("Ingrese nombre: ");
    string nombre2 = Console.ReadLine()!;
    Console.Write("Ingrese edad: ");
    int edad = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese ciudad: ");
    string ciudad = Console.ReadLine()!;

    Console.WriteLine(nombre2);
    Console.WriteLine(edad);
    Console.WriteLine(ciudad);

    Console.WriteLine("10. Verificar si un string es palindromo (igual al reves)");
    string palindromo = "RADAR";
    palindromo = palindromo.ToLower();
    string palindromoinvetido = "";
    for(int i = palindromo.Length - 1; i >=0; i--)
        {
            palindromoinvetido += palindromo[i];
        }
    if (palindromo == palindromoinvetido)
        {
            Console.WriteLine("Es palindromo");
        }
    else
        {       
    Console.WriteLine("No es palindromo");
        }
        }
    
}
    
