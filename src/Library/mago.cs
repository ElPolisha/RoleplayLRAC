using System;
using System.Collections.Generic;
namespace Library;

public class Mago : Personajes
{
    private double poder_magico = 88;
    public Libro_Hechizos libro1a = new Libro_Hechizos("libro2s", "Mago", 2,3);
    public Mago(string nombre)
    {
        this.armas = new List<Elementos>();
        this.nombre = nombre;
        this.estadisticasdellibro();
        Console.Write($"Su nuevo personaje se llama {this.nombre}, nacio con {this.Daño} puntos de ataque base, {this.Defensa} puntos de defensa base y {this.vida} puntos de vida\n");
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

    public void Datos()
    {
        Console.WriteLine($"Datos:\n Daño:{this.Daño} \nDefensa:{this.Defensa}");
    }
}