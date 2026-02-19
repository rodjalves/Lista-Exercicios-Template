// See https://aka.ms/new-console-template for more information
//Exercício 08 - Soma segura

Console.WriteLine(" Informe um número inteiro ");
string dadosEntrada = (Console.ReadLine());
Console.WriteLine(" Informe um outro número inteiro ");
string dadosEntrada1 = (Console.ReadLine());


try
{
    int numero = int.Parse(dadosEntrada);
    Console.WriteLine($" O número inserido está de acordo {numero} ");
    int numero1 = int.Parse(dadosEntrada1);
    Console.WriteLine($" O número inserido está de acordo {numero1} ");
    Console.WriteLine($" A soma dos números inteiros inseridos é {numero + numero1}");
}
catch (FormatException)
{

    Console.WriteLine("Erro: O número informado não parece um número inteiro válido ");
}
finally
{
    Console.WriteLine(" Final da operação da entrada de dados");
}
