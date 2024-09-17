using System;
using System.Collections.Generic;
namespace Library;

public class Mago : Personajes
{
    private double poder_magico = 88;
    public Libro_Hechizos libro1a = new Libro_Hechizos("Libro Encantado", "Mago", 2,3);

    public Mago(string nombre)
    {
        this.armas = new List<Elementos>();
        this.nombre = nombre;
        this.estadisticasdellibro();
        Console.Write($"\n{this.nombre} es un mago que tiene {this.Daño} puntos de ataque, {this.Defensa} puntos de defensa y {this.vida} puntos de vida\n");
    }

    public void agregararmamago(Elementos cosa)
    {
        if (cosa.Tipo == Tipo.Mago)
        {
            armas.Add(cosa);
        }
        else
        {
            Console.WriteLine($"Solo puede agregar armas de mago, a un mago");
        }
    }

    private void estadisticasdellibro()
    {
        this.Daño = Daño + libro1a.GetDaño();
        this.Defensa = Defensa + libro1a.GetDefensa();
    }
    
}