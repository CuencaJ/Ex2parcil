using System;
namespace Examen;
public class napolitano:Ordenbase
{
    public napolitano(Ordenbase orden):base (orden)
    {

    }

    public override double Calculo()
    {
        Console.WriteLine("Precio");
        var precioto1 =base.Calculo();
        return precioto1;
    }



}