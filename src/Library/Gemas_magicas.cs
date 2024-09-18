namespace DefaultNamespace;

public class Gemas_magicas : Elementos
{
    public Gemas_magicas(string nombrearma, string tipo, int durabilidad, int daño_fisico) : base(nombrearma, tipo, durabilidad,
        daño_fisico)
    {
        this.nombre_arma = nombrearma;
        tipo = "Elfo";
        this.defensa_elemento = durabilidad;
        this.daño_elemento = daño_fisico;
    }
}