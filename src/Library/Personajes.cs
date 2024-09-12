
namespace Library;

public class Personajes
{
    private double Vida = 100;
    public double Daño = 50;
    public double Resistencia = 50 ;

    public Personajes(double vida, double daño, double resistencia)
    {
        this.Vida = vida;
        this.Daño = daño;
        this.Resistencia = resistencia;
        Console.Write($"Su personaje tiene {Daño} puntos de daño, {Resistencia} puntos de resistencia y {Vida} puntos de vida\n");
    }

    public void pelear()
    {
        
    }

    public void escapar()
    {
        
    }

    // public Personajes feijoada = new Personajes(100, 90);
}