using System;

//1. Crear Auto con Motor por composicion.

public class Motor
{
    private int _cilindros;

    public int Cilindros
    {
        get { 
            return _cilindros;
            }
    }
    public Motor(int cilindros)
    {
        _cilindros = cilindros;
    }


} 
public class Auto
{
    private string _marca;
    public string Marca
    {
        get { return _marca;}
    }

    private Motor _motor;
    public Motor Motor
    {
        get
        {
            return _motor;
        }
    }
    public Auto (string marca, int cilindros)
    {
        _marca = marca;
        _motor = new Motor (cilindros);
    }
}

//2. Crear Computadora con CPU y RAM por composicion.
public class CPU
{
    private string _cpu;

    public string Cpu
    {
       get{ return _cpu;}
    }
    public CPU (string cpu)
    {
        _cpu = cpu;
    }
}
public class RAM
{
    private int _ram;

    public int Ram
    {
        get
        {
            return _ram;
        }
    }
    public RAM (int ram)
    {
        _ram = ram;
    }
}
public class Computadora
{
    private CPU _cpu;
    public CPU Cpu
    {
        get{return _cpu;}
    }
    private RAM _ram;
    public RAM Ram
    {
        get{return _ram;}
    }
    public Computadora (string cpu,int ram)
    {
        _cpu = new CPU(cpu);
        _ram = new RAM(ram);
    }
}

//8. Crear Factura con lista de Lineas (composicion).

public class LineaFactura
{
    private string _producto;
    public string Producto
    {
        get{return _producto;}
    }
    private decimal _precio;
    public decimal Precio
    {
        get{return _precio;}
    }
    public LineaFactura (string producto, decimal precio)
    {
        _producto = producto;
        _precio = precio;
    }
}

public class Factura
{
    private int _numero;
    public int Numero
    {
        get{return _numero;}
    }

    private List<LineaFactura> _lineas;
    public List<LineaFactura> Lineas
    {
        get {return _lineas;}
    }
    public Factura(int numero)
    {
        _numero = numero;
        _lineas = new List<LineaFactura>();
    }
    public void AgregarLinea(string producto, decimal precio)
    {
        _lineas.Add(new LineaFactura(producto, precio));
    }
}

//4. Crear Colectivo con Conductor por agregacion.



public class Conductor

{

    private string _nombre;

    public string Nombre

    {

        get{return _nombre;}

    }

    public Conductor(string nombre)

    {

        _nombre = nombre;

    }





}

public class Colectivo

{

    private int _linea;

    public int Linea

    {

        get{return _linea;}

    }

    private Conductor _conductor;

    public Conductor Conductor

    {

        get{return _conductor;}

    }



    public Colectivo(int linea)

    {

        _linea = linea;

        _conductor = null;

    }



    public void AgregarConductor(Conductor conductor)
{
    _conductor = conductor;
}

    public void Desvincular()

    {

        _conductor = null;

    }

}

//7. Crear Equipo con lista de Jugadores (agregacion).

public class Jugador

{

    private string _nombreJugador;

    public string NombreJugador

    {

        get{return _nombreJugador;}

    }

    private string _posicion;

    public string Posicion

    {

        get{return _posicion;}

    }

    public Jugador(string nombreJugador,string posicion)

    {

        _nombreJugador = nombreJugador;

        _posicion = posicion;

    }



}

public class Equipo

{

    private string _nombreEquipo;

    public string NombreEquipo

    {

        get{return _nombreEquipo;}

    }

    private List<Jugador> _jugadores;

    public List<Jugador>  Jugadores

    {

        get{return _jugadores;}

    }

    public Equipo(string nombreEquipo)

    {

        _nombreEquipo = nombreEquipo;

        _jugadores = new List<Jugador>();

    }

    public void AgregarJugador(Jugador jugador)

    {

        _jugadores.Add(jugador);

    }

}
class Program
{
    static void Main()
    {
        // 3. Demostrar que Motor no tiene sentido sin Auto.

        // El motor no se crea afuera. Se crea ADENTRO del auto.
        Auto miAuto = new Auto("Toyota", 4); 
        // Si miAuto deja de existir, su Motor interno también desaparece.
        Console.WriteLine($"Auto {miAuto.Marca} con motor de {miAuto.Motor.Cilindros} cilindros.");



        // 5. Demostrar que Conductor existe sin Colectivo.


        // El conductor nace y existe de forma totalmente independiente:
        Conductor chofer1 = new Conductor("Carlos Pérez");
        Console.WriteLine($"Conductor creado independientemente: {chofer1.Nombre}");

        // 6. Reasignar conductor de un colectivo a otro.

        Colectivo colectivoA = new Colectivo(160);
        Colectivo colectivoB = new Colectivo(68);

        // Se asigna al primer colectivo
        colectivoA.AgregarConductor(chofer1);

        // Se desvincula del colectivo A y se pasa al colectivo B
        colectivoA.Desvincular();
        colectivoB.AgregarConductor(chofer1); 

        // 9. Usar ?. para acceder de forma segura a Conductor?.Nombre.
        
        string nombreChoferA = colectivoA.Conductor?.Nombre; 
        Console.WriteLine($"Chofer Colectivo A: {nombreChoferA ?? "Sin conductor asignado"}");

        string nombreChoferB = colectivoB.Conductor?.Nombre;
        Console.WriteLine($"Chofer Colectivo B: {nombreChoferB}");
    }
}

// 10. Documentar con comentarios la diferencia entre ambas relaciones.

/*
 * DIFERENCIA ENTRE COMPOSICIÓN Y AGREGACIÓN:
 * 
 * 1. COMPOSICIÓN (Relación fuerte / "Tiene un"):
 *    - Los objetos dependientes (ej: Motor, LineaFactura) nacen y mueren 
 *      DENTRO del objeto contenedor (Auto, Factura).
 *    - La clase contenedora se encarga de hacer el 'new' internamente.
 *    - Si el contenedor se destruye, los componentes se destruyen con él.
 * 
 * 2. AGREGACIÓN (Relación débil / "Usa un"):
 *    - El objeto secundario (ej: Conductor, Jugador) se crea AFUERA.
 *    - La clase contenedora (Colectivo, Equipo) solo recibe la referencia del objeto ya creado.
 *    - Los objetos tienen vidas independientes: si se destruye el Colectivo o el Equipo,
 *      el Conductor o Jugador sigue existiendo en memoria.
 */