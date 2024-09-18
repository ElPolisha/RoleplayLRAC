namespace LibraryTests;

public class PersonajesTest
{
    [Test]
    public void presentarseTest()
    {
        Mago x = new Mago("Pepe");
        string nombreObtenido = x.presentarse;
        string nombreEsperad = "Pepe";

        Assert.AreEqual(nombreEsperad, nombreObtenido);
    }
    
    [Test]
    public void pelearenserioTest(Personajes x, Personajes y)
    {
        Mago x = new Mago("juancito");
        Mago y = new Mago("pepito");
        int vida_esperada = 26;  //daño total mago estandar 83 & defensa 9
        int vida_Restante = (y.vida + y.Defensa) - (x.Daño);

        Assert.AreEqual(vida_esperada, vida_Restante);
    }

    [Test]
    public void pelearTest()
    {
        Mago x = new Mago("pepe");
        Elementos baston = new Elementos("baston", "Mago", 0, 0);
        int dañoObtenido = x.pelear;
        int dañoEsperado = 83;

        Assert.AreEqual(dañoEsperado,dañoObtenido);
    }

    public void defenderseTest()
    {
        Mago x = new Mago("jabonete");
        Elementos baston = new Elementos("baston", "Mago", 0, 0);
        int defensaObtenida = x.defenderse;
        int defensaEsperada = 9;

        Assert.AreEqual(defensaEsperada,defensaObtenida);
    }
}