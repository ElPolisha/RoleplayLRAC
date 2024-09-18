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
            Mago mago2 = new Mago("Zambuco");
            mago1.agregararmamago(new Elementos("baston", "Mago", 20, 2));
            mago2.agregararmamago(new Elementos("baston oscuro", "Mago", 3, 18));
            Console.WriteLine($"\n {mago1.presentarse()} tiene {mago1.pelear()} de ataque y {mago1.defenderse()} de defensa");
            Console.WriteLine($"\n {mago2.presentarse()} tiene {mago2.pelear()} de ataque y {mago2.defenderse()} de defensa \n");
            mago1.pelearseenserio(mago1, mago2);
            Console.WriteLine($" {mago2.presentarse()} se curo y ahora tiene {mago2.curarse()} puntos de vida\n");

        }
    }
}