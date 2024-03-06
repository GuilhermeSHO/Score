using System;

class Cliente
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Score { get; set; }

    public void AnalisarScore()
    {
        if (Score >= 800)
        {
            Console.WriteLine("Ótimo cliente");
        }
        else if (Score >= 500 && Score <= 799)
        {
            Console.WriteLine("Precisa de análise");
        }
        else
        {
            Console.WriteLine("Precisa de outras análises");
        }
    }
}

class Produto
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public double Desconto { get; set; }

    public void AnalisarDesconto()
    {
        decimal valorComDesconto = Valor - (Valor * (decimal)(Desconto / 100));
        Console.WriteLine($"Valor do produto com desconto: R${valorComDesconto}");
    }
}

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente();
        cliente.Nome = "João";
        cliente.Idade = 30;
        cliente.Score = 750;

        cliente.AnalisarScore();

        Produto produto = new Produto();
        Console.Write("Digite a descrição do produto: ");
        produto.Descricao = Console.ReadLine();

        Console.Write("Digite o valor do produto: ");
        produto.Valor = decimal.Parse(Console.ReadLine());

        Console.Write("Digite o desconto em %: ");
        produto.Desconto = double.Parse(Console.ReadLine());

        produto.AnalisarDesconto();
    }
}