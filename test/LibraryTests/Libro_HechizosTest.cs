namespace LibraryTests;

public class Libro_HechizosTest
{
    [Test]
    public void calculohechizostest()
    {
        // EL método se ejecuta en el constructor, así que testeamos los valores que modifica
        Libro_Hechizos pruebalibro = new Libro_Hechizos("libro", "Mago", 1, 2);
        int resultadoDefensaEsperado = 2;
        int resultadoAtaqueEsperado = 72;
        int resultadoDefensaObtenido = pruebalibro.GetDefensa();
        int resultadoAtaqueObtenido = pruebalibro.GetDaño();
        
        Assert.AreEqual(resultadoAtaqueEsperado,resultadoAtaqueObtenido);
        Assert.AreEqual(resultadoDefensaEsperado,resultadoDefensaObtenido);
        
    }
}