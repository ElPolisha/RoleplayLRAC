using System;
using System.Collections.Generic;
namespace Library;

public class Elementos
{
    public string nombre_arma ;
    public int defensa_elemento ;
    public int daño_elemento ;
    
    public Tipo Tipo { get; private set; }
    
    public Elementos (string nombrearma, string tipo, int durabilidad, int daño_fisico)
    {
        if (!Enum.TryParse(tipo, true, out Tipo tipoEnum))
        {
            throw new ArgumentException($"{tipo} no es un valor válido para el enum Tipo.");
        }

        Tipo = tipoEnum;
        this.nombre_arma = nombrearma;
        this.defensa_elemento = durabilidad;
        this.daño_elemento = daño_fisico;
        Console.Write($"\nUsted creo un {nombrearma} con {durabilidad} defensa y {daño_fisico} puntos de daño.");
    }
    
    public int GetDefensa()
    {
        return this.defensa_elemento;
    }

    public int GetDaño()
    {
        return this.daño_elemento;
    }
}