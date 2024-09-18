using System;
using System.Collections.Generic;
namespace Library;

public class Libro_Hechizos : Elementos
{
    public List<Hechizos> hechizosenlista;

    public Libro_Hechizos(string nombrearma, string tipo, int durabilidad, int daño_libro) : base(nombrearma,
        tipo, durabilidad, daño_libro)
    {
        this.nombre_arma = nombrearma;
        tipo = "Mago";
        this.defensa_elemento = 0;
        this.daño_elemento = 0;

        this.hechizosenlista = new List<Hechizos>();
        hechizosenlista.Add(new Hechizos());

        this.calculohechizos();
    }

    private void calculohechizos()
    {
        foreach (Hechizos hechizo in hechizosenlista)
        {
            this.daño_elemento += hechizo.Ataque_hechizo;
            this.defensa_elemento += hechizo.Defensa_hechizo;
        }
    }
}