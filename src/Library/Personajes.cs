
namespace Library;

public class Personajes
{
    private string Nombre = "personaje";
    private double Vida = 100;
    public double Daño = 50;
    public double Defensa = 50;

    public Personajes(string nombre,double vida, double daño, double resistencia)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Daño = daño;
        this.Defensa = resistencia;
        Console.Write($"Su nuevo personaje se llama {Nombre}, nacio con {Daño} puntos de ataque base, {Defensa} puntos de defensa base y {Vida} puntos de vida\n");
    }

    public void pelear()
    {
        
    }

    public void escapar()
    {
        
    }

    // public Personajes feijoada = new Personajes(100, 90);
    // feijoada.Mago()
}