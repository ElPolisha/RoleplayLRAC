using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Mago mago1 = new Mago("Feijoada");
            Enano enano1 = new Enano("Cachete_Killer");
            //Mago mago2 = new Mago("Zambuco");
            mago1.agregararmamago(new Elementos("baston", "Mago", 20, 2));
            enano1.agregararmaenano(new Elementos("mazacote", "Enano", 9, 33));
            //mago2.agregararmamago(new Elementos("baston oscuro", "Mago", 3, 18));
            Console.WriteLine($"\n {mago1.presentarse()} tiene {mago1.pelear()} de ataque y {mago1.defenderse()} de defensa");
            Console.WriteLine($"\n {enano1.presentarse()} tiene {enano1.pelear()} de ataque y {enano1.defenderse()} de defensa\n");
            //Console.WriteLine($"\n {mago2.presentarse()} tiene {mago2.pelear()} de ataque y {mago2.defenderse()} de defensa \n");
            mago1.pelearseenserio(mago1, enano1);
            Console.WriteLine($" {enano1.presentarse()} se curo y ahora tiene {enano1.curarse()} puntos de vida\n");
        }
    }
}