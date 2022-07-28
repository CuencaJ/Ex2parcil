using System;
namespace Examen;
public class toping2:decorador
{
    public toping2(Ordenbase orden):base (orden)
    {

    }

    public override double Calculo()
    {
        Console.WriteLine("Precio");
        var precioto1 =base.Calculo();
        return precioto1+1.00;
    }
}