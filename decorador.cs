using System;
namespace Examen;
public class decorador:Ordenbase
{
    protected Ordenbase orden;
    public decorador (Ordenbase orden)
    {
        this.orden=orden;
    }
    public override double Calculo()
    {
        Console.WriteLine("Calculo del precio total");
        return orden.Calculo();
    }
    }