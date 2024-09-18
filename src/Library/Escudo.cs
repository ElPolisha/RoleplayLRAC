namespace Library;

public class Escudo : Elementos
{
    public Escudo(string nombrearma, string tipo, int durabilidad, int daño_fisico) : base(nombrearma, tipo, durabilidad,
        daño_fisico)
    {
        this.nombre_arma = nombrearma;
        tipo = "Escudero";
        this.defensa_elemento = durabilidad;
        this.daño_elemento = daño_fisico;
    }
}