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
	public List<Mago> Los_Magos;
	//public List<Elfos> Los_Elfos;
	//public List<Enanos> Los_Enanos;
	//public List<Escuderos> Los_Escuderos;
    
	public string presentarse()
	{
		return this.nombre;
	}
    
	public void pelearseenserio(Personajes atacante, Personajes atacado)
	{
		int vida_Restante; 
		vida_Restante = (atacado.vida + atacado.Defensa) - (atacante.Daño);

		if(vida_Restante < 0)
			{
				Console.WriteLine($"{atacado.presentarse()} fue victima de {atacante.presentarse()} con un daño de {atacante.pelear()}\n");
			}
		else
			{
				Console.WriteLine($"Luego de una ardua batalla entre {atacante.presentarse()} y {atacado.presentarse()} resultando que este ultimo quede con con {vida_Restante} puntos de vida\n"); 
			}
	}

    public int pelear()
    {
        int dañoactual = this.Daño;
        foreach (Elementos elemento in armas)
        {
            dañoactual += elemento.GetDaño();
        }
        return dañoactual;
    }

	public int defenderse()
    {
        int defensaactual = this.Defensa;
        foreach (Elementos elemento in armas)
        {
            defensaactual += elemento.GetDefensa();
        }
        return defensaactual;
    }

/*
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
*/
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

    public int curarse()
    {
        if (vida <100)
        {
            vida = 100;
        }
	return vida;
    }
}