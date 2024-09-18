namespace Library;
public class Cerveza : Elementos
{
    public Cerveza(string nombrearma, string tipo, int durabilidad, int daño_fisico) : base(nombrearma, tipo, durabilidad, daño_fisico)
    {
        this.nombre_arma = nombrearma;
        tipo = "Enano";
        this.defensa_elemento = durabilidad;
        this.daño_elemento = daño_fisico;
    }
}