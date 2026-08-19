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