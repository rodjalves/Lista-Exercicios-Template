// See https://aka.ms/new-console-template for more information
//Exercício 15 - Simulador de compra
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Console.WriteLine(" Informe o nome do produto");
        var nomeProduto = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" Informe o preço unítário do produto");
        var preçoProduto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Informe a quantidade desejada do produto");
        var quantProduto = int.Parse(Console.ReadLine());
        var valorTotal = quantProduto * preçoProduto;
        Console.WriteLine(" Resumo da Compra! " + Environment.NewLine + "Nome do ítem : " + nomeProduto + Environment.NewLine+ "Quantidade: " + quantProduto + Environment.NewLine  +  "Valor total da compra " + valorTotal.ToString("C2"));

    }
}



