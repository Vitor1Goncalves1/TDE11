public class Carro : Veiculo
{
    private int numDePortas;

    public Carro(string marca, string modelo, string ano, int numDePortas)
    :base(marca, modelo, ano)
    {
        this.numDePortas = numDePortas;
    }

    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo{modelo}, Ano{ano}, Numero de Portas{numDePortas}");
    }
}