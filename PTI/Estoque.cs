using System;

public class Estoque
{
    private const int Totaldecarros = 5;
    private Carros[] carros = new Carros[Totaldecarros];
    private int qtdcarros = 0;

    public void AdicionarCarro()
    {
        if (qtdcarros >= Totaldecarros)
        {
            Console.WriteLine("O estoque atingiu o seu limite.\n");
            return;
        }

        Carros novoCarro = new Carros();

        Console.Write("Nome do carro: ");
        novoCarro.Nome = Console.ReadLine();

        Console.Write("Cor do carro: ");
        novoCarro.Cor = Console.ReadLine();

        Console.Write("Ano do carro: ");
        novoCarro.ano = int.Parse(Console.ReadLine());

        Console.Write("Categoria do carro: ");
        novoCarro.Categoria = Console.ReadLine();

        Console.Write("Modelo do carro: ");
        novoCarro.Modelo = Console.ReadLine();

        novoCarro.Quantidade = 0;

        carros[qtdcarros] = novoCarro;
        qtdcarros++;
        Console.WriteLine("Carro adicionado \n");
    }

    public void ListarCarros()
    {
        if (qtdcarros == 0)
        {
            Console.WriteLine("Sem carros no estoque.");
        }
        else
        {
            for (int i = 0; i < qtdcarros; i++)
            {
                Console.WriteLine($"Código: {i + 1}");
                Console.WriteLine($"Nome: {carros[i].Nome}");
                Console.WriteLine($"Modelo: {carros[i].Modelo}");
                Console.WriteLine($"Cor: {carros[i].Cor}");
                Console.WriteLine($"Ano: {carros[i].ano}");
                Console.WriteLine($"Categoria: {carros[i].Categoria}");
                Console.WriteLine($"Quantidade: {carros[i].Quantidade}");
                Console.WriteLine();
            }
        }
    }

    public void RemoverCarro()
    {
        Console.Write("Digite o código do carro a ser removido: ");
        int codigo = int.Parse(Console.ReadLine()) - 1;

        if (codigo >= 0 && codigo < qtdcarros)
        {
            for (int i = codigo; i < qtdcarros - 1; i++)
            {
                carros[i] = carros[i + 1];
            }
            carros[qtdcarros - 1] = null; // Limpa a última posição
            qtdcarros--;
            Console.WriteLine("Carro removido!\n");
        }
        else
        {
            Console.WriteLine("Código inválido.\n");
        }
    }

    public void EntradaEstoque()
    {
        Console.Write("Digite o código do carro para adicioná-lo ao estoque: ");
        int codigo = int.Parse(Console.ReadLine()) - 1;

        if (codigo >= 0 && codigo < qtdcarros)
        {
            Console.Write("Digite a quantidade a ser adicionada: ");
            int quantidade = int.Parse(Console.ReadLine());
            carros[codigo].Quantidade += quantidade;
            Console.WriteLine("Quantidade adicionada com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Código inválido.\n");
        }
    }

    public void SaidaEstoque()
    {
        Console.Write("Digite o código do carro para remover do estoque: ");
        int codigo = int.Parse(Console.ReadLine()) - 1;

        if (codigo >= 0 && codigo < qtdcarros)
        {
            Console.Write("Digite a quantidade a ser removida: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= carros[codigo].Quantidade)
            {
                carros[codigo].Quantidade -= quantidade;
                Console.WriteLine("Quantidade removida com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Não há carros suficientes no estoque.\n");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.\n");
        }
    }
}
