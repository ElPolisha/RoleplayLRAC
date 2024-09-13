using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new Mago("mago1");
            mago1.agregararmamago(new Elementos("hola", "Mago", 20, 2));
            Console.WriteLine(mago1.pelear());
        }
    }
}