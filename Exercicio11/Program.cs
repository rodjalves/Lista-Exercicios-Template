// See https://aka.ms/new-console-template for more information
//Exercício 11 - Troco

Console.WriteLine("Informe o valor do produto: ");
var preçoProduto = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o valor pago: ");
var valorPago = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine($"O valor do troco devido ao cliente é R$: {valorPago - preçoProduto} ");

if (valorPago >= preçoProduto)
{
    Console.WriteLine($"O valor do troco devido ao cliente é R$: {valorPago - preçoProduto} ");
}
else
{
    Console.WriteLine(" O valor pago é inferior ao preço do produto");
}
