namespace LibraryTests;

public class ElementosTest
{
    [Test]
    public void GetDefensatest()
    {
        Elementos prueba = new Elementos("Nombre", "Mago", 1, 2); //creo un elemento para probarlo
        int resultado_esperado = 1;
        int resultado_obtenido = prueba.GetDefensa();
        Assert.AreEqual(resultado_esperado, resultado_obtenido);
    }
    [Test]
    public void GetDañotest()
    {
        Elementos prueba = new Elementos("Nombre", "Mago", 1, 2); //creo un elemento para probarlo
        int resultado_esperado = 2;
        int resultado_obtenido = prueba.GetDaño();
        Assert.AreEqual(resultado_esperado, resultado_obtenido);
    }
}