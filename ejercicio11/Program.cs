using System;

public class CuentaBancaria
{
    private decimal saldo;
    private readonly int numeroCuenta;

    public void Depositar(decimal monto)
    {
        if(monto > 0)
        {
            saldo += monto;
        }
    }
    public void Retirar(decimal monto)
    {
        if(saldo >= monto && monto> 0)
        {
            saldo -= monto;
        }
    }
    const double IVA = 0.21;
public class Temperatura
    {
    private int _temperatura;
    public int _Temperatura{
        get{return _temperatura;}
        set{if(value >= -273)
            {
               _temperatura = value;
                }
            else
                {
                 Console.WriteLine("No puede haber temperatura bajo del cero absoluto");   
                }
        }
        }
        
        }
public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }
        public string Apellido
        {
            get{return apellido;}
            set{apellido = value;}
        }
        public int DNI
        {
            get{return dni;}
            set{dni = value;}
        }
        public int Edad
        {
            get{return edad;}
            set{if(value >= 150)
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("Edad sin validación");
                }
            }
        }
        

    }
public class Rectangulo
    {
        public double Ancho;
        public double Alto; 
        
        public double Perimetro;
        
    }
}