public class Moto : Veiculo
{
    private bool TemPagageiro;

    public Moto(string marca, string modelo, int ano, bool TemPagageiro) :base(marca, modelo, ano)
    {
        this.TemPagageiro = TemPagageiro;
    }
    public void DarGrau()
    {
        Console.WriteLine("randandandandan pa pa pa ai minha perna queimou no escapamento")
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo {modelo}, Ano {ano}");
    }

}