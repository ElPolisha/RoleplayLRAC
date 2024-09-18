using System.Numerics;
using System;
using System.Collections.Generic;
namespace Library;

public class Elfo : Personajes
{
    private int Sentido_aumentado = 50;
    public Gemas_magicas gema1 = new Gemas_magicas("Esmeralda", "Elfo", 25, 25);

    public Elfo(string nombre)
    {
        this.armas = new List<Elementos>();
        this.nombre = nombre;
        //this.estadisticasGema();
        Console.WriteLine($"{this.nombre} es un escudero, tiene {this.Daño} puntos de ataque, {this.Defensa} puntos de defensa y {this.vida} puntos de vida");
    }
    
    public void agregararmaElfo(Elementos cosa)
    {
        if (cosa.Tipo == Tipo.Elfo)
        {
            armas.Add(cosa);
        }
        else
        {
            Console.WriteLine($"Solo se puede agregar armas de elfo, a un elfo");
        }
    }

    private void estadisticasGema()
    {
        this.Daño = Daño + gema1.GetDaño();
        this.Defensa = Defensa + gema1.GetDefensa();
    }
}