using System;
using System.Collections.Generic;
namespace Library;

public class Personajes
{
    public string nombre = "personaje";
    public int vida = 100;
    public int Daño = 8;
    public int Defensa = 5;
    public List<Elementos> armas;
    
    
    public int pelear()
    {
        int dañoactual = this.Daño;
        foreach (Elementos elemento in armas)
        {
            dañoactual += elemento.GetDaño();
        }
        return dañoactual;
    }

    public void recibir_ataque(int ataquerecibido)
    {
        int defensactual = this.Defensa;
        foreach (Elementos elemento in armas)
        {
            defensactual += elemento.GetDefensa();
        }
        if (defensactual < ataquerecibido)
        {
            this.vida -= ataquerecibido - defensactual;
            Console.WriteLine($"El elemento {this.nombre} quedo con {this.vida} puntos de salud.");
        }
    }

    public void equipar_arma(Elementos esto)
    {
        armas.Add(esto);
    }
    public void desequipar_arma(Elementos coso)
    {
        if (armas.Contains(coso));
        {
            armas.Remove(coso);
        }
    }

    public void curarse()
    {
        if (vida <100)
        {
            vida = 100;
        }
    }
}