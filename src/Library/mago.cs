namespace Library;

public class mago
{
    private double poder_magico = 88;
    private string sabiduria = "alta";
    private double baston = 60;
    private double libro_magico = 55;
    
    public void combate_magico()
    {
        Daño = Daño + poder_magico;
        Console.Write($"El mago azota con llamaradas a sus enemigos infringiendo {Daño} puntos de daño.\n");
    }

    public void usar_baston_magico()
    {
        Daño = Daño + baston;
        Console.Write($"El mago lanza una esfera de energia infringiendo {Daño} puntos de daño");
    }

    public void usar_libro_de_magia()
    {
        Console.Write($"El mago aumenta su sabiduria utilizando el libro de hechizos.");
    }
}