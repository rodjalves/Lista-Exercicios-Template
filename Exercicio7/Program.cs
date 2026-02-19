// See https://aka.ms/new-console-template for more information
//Exercício 07 - Leitura segura de número
Console.WriteLine(" Informe um número inteiro ");
string dadosEntrada = (Console.ReadLine());
try
{
    int numero = int.Parse(dadosEntrada);
    Console.WriteLine($" O número inserido está de acordo {numero} ");
}
catch (FormatException)
{

Console.WriteLine("Erro: O número informado não parece um número inteiro válido ");
}
finally
{
    Console.WriteLine(" Final da operação da entrada de dados");
