using System;
namespace Examen;
public class vainilla:Ordenbase
{
    public vainilla(Ordenbase orden):base (orden)
    {

    }

    public override double Calculo()
    {
        Console.WriteLine("Precio");
        var precioto1 =base.Calculo();
        return precioto1;
    }
}