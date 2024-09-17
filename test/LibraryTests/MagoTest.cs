namespace LibraryTests;

public class MagoTest
{
    [Test]
    public void agregararmamagoTest()
    {
        Mago magoprueba = new Mago("pepe");
        magoprueba.agregararmamago(new Elementos("baston", "Mago", 20, 2));
        int resultadoEsperado = 1; // yo espero que el mago tenga solo un arma 
        int resultadoObtenido = magoprueba.armas.Count(); //la cantidad de armas que tiene la lista de armas
        Assert.AreEqual(resultadoEsperado,resultadoObtenido);
    }

    [Test]
    public void estadisticasdellibroTest()
    {
        Mago magoprueba2 = new Mago("josue");
        int resultadoDañoesperado = 80;
        int resultadoDefensaesperado = 7;
        int resultadoDañoobtenido = magoprueba2.Daño;
        int resultadoDefensaobtenido = magoprueba2.Defensa;
        
        Assert.AreEqual(resultadoDañoesperado,resultadoDañoobtenido);
        Assert.AreEqual(resultadoDefensaesperado,resultadoDefensaobtenido);
    }
}