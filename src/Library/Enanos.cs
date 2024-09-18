using System.Numerics;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace Library;

public class Enano : Personajes
{
    private int ResFísica = 70;
    public Cerveza Duff = new Cerveza("Jarra de Cerveza", "Enano", 50, -5);


    public Enano(string nombre);
    {
        this.armas = new List<Elementos>();
        this.nombre = nombre;
        this.estadisticasCerveza();
        Console.Write($"\n{this.nombre} es un Enano que tiene {this.Daño} puntos de ataque, {this.vida} puntos de vida\n");
    }

    public void agregararmaenano(Elementos cosa)
    {
        if (cosa.Tipo == Tipo.Enano)
        {
            armas.Add(cosa);
        }
        else
        {
            Console.WriteLine($"Solo puede agregar armas de Enano, a un Enano");
        }
    }

    private void estadisticasCerveza()
    {
        this.Daño = Daño + Duff.GetDaño();
        this.Defensa = Defensa + Duff.GetDefensa();
    }
}
    