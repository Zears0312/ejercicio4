using System;

public class Rectangulo
{
    public int Ancho {get; set;}
    public int Alto {get; set;}
    public Rectangulo (int ancho, int alto){
        Ancho = ancho;
        Alto = alto;
    }
    public Rectangulo(int lado) : this(lado, lado) { }
    public Rectangulo() : this(1,1){}
}
public class Persona
{
    private static int contadorId = 0;
    public int Id { get; }
    public string Nombre { get; set; }

    public Persona() {
        Id = ++contadorId;
    }
}

public class Fraccion
{
    public int Numerador {get; set;}
    public int Denominador {get; set;}

    public Fraccion(int numerador, int denominador)
    {
        if(denominador != 0)
        {
            Numerador = numerador;
            Denominador = denominador;
        }
    }
    public Fraccion(int entero) : this(entero, 1) { }
}

public class Alumno {
    public string Nombre;

    public Alumno(string Nombre) {
        this.Nombre = Nombre;
    }
}
public class Jugador {
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Jugador Mover(int dx, int dy) {
        X += dx;
        Y += dy;
        return this;
    }

    public Jugador Atacar() {
        
        return this;
    }
}

public class Singleton {
    private static Singleton instancia;

    private Singleton() { } 

    public static Singleton ObtenerInstancia() {
        if (instancia == null) {
            instancia = new Singleton();
        }
        return instancia;
    }
}
public class Config
{
    public string Idioma {get;set;}
    public Config(){
        Idioma = "Español";
        
    }
}