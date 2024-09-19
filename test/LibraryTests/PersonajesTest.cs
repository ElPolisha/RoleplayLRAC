namespace LibraryTests;

public class PersonajesTest
{
    [Test]
    public void presentarseTest()
    {
        Mago x = new Mago("Pepe");
        string nombreObtenido = $"{x.presentarse}";
        string nombreEsperad = "Pepe";

        Assert.AreEqual(nombreEsperad, nombreObtenido);
    }
    
    [Test]
    public void pelearenserioTest()
    {
        Mago atacante = new Mago("juancito");
        Mago atacado = new Mago("pepito");
        int vida_esperada = 26;  //daño total mago estandar 83 & defensa 9
        atacante.pelearseenserio(atacante, atacado);

        Assert.AreEqual(vida_esperada, atacado.vida);
    }

    [Test]
    public void pelearTest()
    {
        Mago x = new Mago("pepe");
        Elementos baston = new Elementos("baston", "Mago", 0, 0);
        x.agregararmamago(baston);
        int dañoObtenido = x.pelear();
        int dañoEsperado = 83;

        Assert.AreEqual(dañoEsperado,dañoObtenido);
    }

    public void defenderseTest()
    {
        Mago x = new Mago("jabonete");
        Elementos baston = new Elementos("baston", "Mago", 0, 0);
        x.agregararmamago(baston);
        int defensaObtenida = x.defenderse();
        int defensaEsperada = 9;

        Assert.AreEqual(defensaEsperada,defensaObtenida);
    }
}