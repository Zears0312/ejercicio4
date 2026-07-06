using System;

    public class Persona
    {
        public string Nombre;
        public int edad;

        public void Presentarse()
        {
            Console.WriteLine($"Mi nombre es {Nombre} y tengo {edad} años");
        }
        public bool EsMayor()
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
    public class Rectangulo
    {
        public double Ancho;
        public double Alto;
        public double Area()
        {
            return Ancho * Alto;
        }
        public double Perimetro()
        {
            return (Ancho + Alto) * 2;
        }
    }
    public class Auto()
    {
        public string Marca;
        public string Modelo;
        public int Año;
        public void Informacion()
        {
            Console.WriteLine($"Marca: {Marca} Modelo: {Modelo} Año: {Año}");
        }
    }
class Program
    {
        static void Main()
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Pepito";
            persona1.edad = 20;
            Console.WriteLine($"¿Es mayor de edad?: {persona1.EsMayor()}");
            
            Persona persona2 = new Persona();
            persona2.Nombre = "Juan";
            persona2.edad = 18;
            Console.WriteLine($"Es mayor de edad? {persona2.EsMayor()}");

            Persona persona3 = new Persona();
            persona3.Nombre = "Pedro";
            persona3.edad = 17;
            Console.WriteLine($"Es mayor de edad? {persona3.EsMayor()}");

            Auto auto1 = new Auto();

            auto1.Marca = "Ferrari";
            auto1.Modelo = "488 GT";
            auto1.Año = 2020;

            Auto auto2 = new Auto();
            auto2.Marca = "Tesla";
            auto2.Modelo = "Model 3";
            auto2.Año = 2023;

            Auto auto3 = new Auto();
            auto3.Marca = "Ford";
            auto3.Modelo = "Mustang";
            auto3.Año = 1967;

            auto1.Informacion();
            auto2.Informacion();
            auto3.Informacion();

            Persona[] Personas = new Persona[3];
            Personas[0] = persona1;
            Personas[1] = persona2;
            Personas[2] = persona3;

            foreach (Persona p in Personas)
            {
                p.Presentarse();
            }
        }
    }