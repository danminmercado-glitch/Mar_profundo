using UnityEngine;

public class Sist_Decisiones
{
    public DatosJugador datosJugador;
}

public class Cigarro
{
    public bool encendido;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (encendido)
        {
            // Lógica para cuando el cigarro está encendido
            datosJugador.conciencia -= 5;
            datosJugador.evasion += 15;
            datosJugador.control += 5;
        }
        else
        {
            // Lógica para cuando el cigarro está apagado
            datosJugador.conciencia += 10;
            datosJugador.evasion -= 10;
            datosJugador.control -= 5;
        }
    }
}

public class Cuter
{
    public bool usarlo;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (usarlo)
        {
            datosJugador.conciencia -= 10;
            datosJugador.evasion += 10;
            datosJugador.control += 10;
        }
        else
        {
            datosJugador.conciencia += 15;
            datosJugador.evasion -= 10;
            datosJugador.control -= 5;
        }
    }
}

public class Botellas
{
    public bool beber;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (beber)
        {
            datosJugador.conciencia -= 10;
            datosJugador.evasion += 15;
            datosJugador.control += 5;
        }
        else
        {
            datosJugador.conciencia += 10;
            datosJugador.evasion -= 10;
            datosJugador.control -= 5;
        }
    }
}

public class Maquillaje
{
    public bool usar;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (usar)
        {
            datosJugador.conciencia -= 5;
            datosJugador.evasion += 10;
            datosJugador.control += 5;
        }
        else
        {
            datosJugador.conciencia += 10;
            datosJugador.evasion -= 5;
            datosJugador.control -= 5;
        }
    }
}

public class Oso
{
    public bool abrazar;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (abrazar)
        {
            datosJugador.conciencia += 15;
            datosJugador.evasion -= 5;
            datosJugador.control += 10;
        }
        else
        {
            datosJugador.conciencia += 5;
            datosJugador.evasion += 10;
            datosJugador.control += 5;
        }
    }
}

public class Telefono
{
    public bool Bloquear;

    public void AplicarEfecto(DatosJugador datosJugador)
    {
        if (Bloquear)
        {
            datosJugador.conciencia += 15;
            datosJugador.evasion -= 10;
            datosJugador.control += 5;
        }
        else
        {
            datosJugador.conciencia -= 5;
            datosJugador.evasion += 10;
            datosJugador.control -= 5;
        }
    }
}