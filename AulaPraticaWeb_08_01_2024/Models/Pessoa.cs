namespace AulaPraticaWeb_08_01_2024.Models;

public class Pessoa : IPessoa
{
    public string Nome{ get; set; }
    public string Sobrenome { get; set; }
    public int Idade { get; set; }
    public string CorPele { get; set; }
    public string CorOlhos { get; set; }

    public Pessoa()
    {
        Nome="Rafael";
        Sobrenome="Rodrigo";
        Idade=28;
        CorPele="Castanho";
        CorOlhos="Castanho";
    }

    public string Andar()
    {
        return "Andando";
    }
    public string Andar(int velocidade)
    {
        return $"Andando a {velocidade} velocidade.";
    }
    public string Parar()
    {
        return "Parei";
    }
    public string Comer()
    {
        return "Comendo";
    }

    public override string ToString()
    {
        return $"{Parar()} {Andar()} {Comer()}";
    }
}
