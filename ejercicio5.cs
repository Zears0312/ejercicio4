using System;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        //21. Verificar si un numero es par o impar con if.
        int numero = 10/2;
        if (numero)
        {
            Console.WriteLine($"Tu numero es par: {numero}");

        }
        else
        {
            Console.WriteLine($"Tu numero no es par: {numero}");
        }
        //22. Clasificar un numero como positivo, negativo o cero.
        int positivo = 5;
        int negativo = -3;
        int cero = 0;
        //23. Validar mayoria de edad (>= 18) con mensaje descriptivo.
        int edad=17;
        if (edad >= 18)
        {
            Console.WriteLine("Sos mayor de edad");

        }
        else
        {
            Console.WriteLine("Sos menor de edad");
        }
        //24. Usar && para verificar que un numero esta entre 1 y 100.
        int condicion = 50;
        int condicion2 = 100;
        if (condicion && condicion2)
        {
            Console.WriteLine("Tu condicion esta entre el 1 y 100");
        }
        else
        {
            Console.WriteLine("Tu condicion no esta entre 1 y 100");
        }
        //25. Usar || para verificar si es fin de semana (sabado o domingo).
        string dia = "sabado";
        if(dia=="sabado" || dia == "lunes")
        {
            Console.WriteLine("Es fin de semana");
        }
        else
        {
            Console.WriteLine("No es fin de semana");
        }
        //26. Usar el operador ternario para asignar 'mayor'/'menor' segun edad.
        int edad2 =18;
        string edad3 = edad2 >=18 ? "Mayor":"Menor";
        Console.WriteLine(edad3);
        //27. Crear switch para dias de la semana.
        int dias = 5;
        switch (dias)
        {
            case 1: Console.WriteLine("Lunes"); 
            break; 
            case 2: Console.WriteLine("Martes");
            break;
            case 3: Console.WriteLine("Miercoles");
            break;
            case 4: Console.WriteLine("Jueves");
            break;
            case 5: Console.WriteLine("Viernes");
            break;
            case 6: Console.WriteLine("Sabado");
            break;
            case 7: Console.WriteLine("Domingo");
            break;
            case default: Console.WriteLine("Dia invalido");

        }  
        //28. Crear switch expression para categorias de producto.
        int producto = 1;
        string nombreProducto = producto switch
        {
            1 => "Zapatos", 2=> "Herramientas", 3=>"Cajas" 
        };
        //29. Usar if anidado: mayor de edad Y tiene licencia.
        int edad5 = 19;
        bool licencia = true;
        if (edad5 >= 18)
        {
            Console.WriteLine("Sos mayor de edad");
            if (licencia)
            {
                Console.WriteLine("Tienes licencia");
            }
        }else if (edad5 < 18)
        {
            Console.WriteLine("Sos menor de edad");
        }
        


    
    }
}