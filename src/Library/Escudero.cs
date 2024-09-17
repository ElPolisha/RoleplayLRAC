using System.Numerics;
using System;
using System.Collections.Generic;
namespace Library;

public class Escudero : Personajes
{
    private int Armadura = 50;
    public Escudo Escudo1 = new Escudo("Escudote", "Escudero", 50, 10);

    public Escudero(string nombre)
    {
        this.armas = new List<Elementos>();
        this.nombre = nombre;
        this.estadisticasEscudo();
        Console.WriteLine($"{this.nombre} es un escudero, tiene {this.Daño} puntos de ataque, {this.Defensa} puntos de defensa y {this.vida} puntos de vida");
    }
    
    public void agregararmaEscudero(Elementos cosa)
    {
        if (cosa.Tipo == Tipo.Escudero)
        {
            armas.Add(cosa);
        }
        else
        {
            Console.WriteLine($"Solo se puede agregar armas de escudero, a un escudero");
        }
    }

    private void estadisticasEscudo()
    {
        this.Daño = Daño + Escudo1.GetDaño();
        this.Defensa = Defensa + Escudo1.GetDefensa();
    }
}