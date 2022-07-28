using System;
namespace Examen;
public class chocolate:Ordenbase
{
    public chocolate(Ordenbase orden):base (orden)
    {

    }

    public override double Calculo()
    {
        Console.WriteLine("Precio");
        var precioto1 =base.Calculo();
        return precioto1;
    }
}

    