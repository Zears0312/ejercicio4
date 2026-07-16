using System;

public class Persona
{
    public string Nombre;
    private static int _contadorIds = 0;
    private readonly int _idPersona;
    public Persona()
    {
        _contadorIds++;
        _idPersona = _contadorIds;
    }
    }
