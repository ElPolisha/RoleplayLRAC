namespace Library;

public class mago
{
    private double poder_magico = 88;
    private string sabiduria = "alta";

    public void combate_magico(Mago elemento)
    {
        if elemento == baston_magio
        {
            Console.write($"El mago lanza una bola de fuego y causa {Daño} puntos de daño a su enemigo")
        }
        else
        {
            Console.write($"El mago solo solo puede atacar con un elemento valido a su clase.\n")
        }
    }

    public void aprender_hechizo(Mago elemento)
    {
        if elemento == libro_de_magia
        {
            Console.Write($"El mago aumenta su sabiduria y aumenta el daño de bola de fuego.\n")
        }
        else
        {
            Console.Write($"El mago solo puede aumentar su sabiduria con un elemento valido a su clase.\n")
        }
    }
}