using System;

public class CuentaBancaria
{
    const decimal IVA = 0.21m;
    private decimal _saldo;
    private readonly int _numeroCuenta;

    public CuentaBancaria (int NumeroCuenta)
    {
        _numeroCuenta = NumeroCuenta;
    }

    public void Depositar(decimal monto)
    {
        if(monto > 0)
        {
            _saldo += monto;
        }
    }
    public void Retirar(decimal monto)
    {
        if(_saldo >= monto && monto> 0)
        {
            _saldo -= monto;
        }
    }
    
}
public class Clima
{
    private int _temperatura;
    public int Temperatura{
        get{return _temperatura;}
        set{if(value > -273)
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
        private string _contraseña;

        public string Contraseña
        {       
            set { _contraseña = value; } 
        }
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
            set{if(value >= 0 && value <= 150)
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
        
        public double Perimetro
    {
        get
        {
            return 2 * (Ancho + Alto);
        }
    }
        
    }