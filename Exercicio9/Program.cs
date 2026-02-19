// See https://aka.ms/new-console-template for more information
// Exercício 09 - Divisão segura

using System.Runtime.Serialization;

Console.WriteLine(" Informe um número inteiro ");
string dadosEntrada = Console.ReadLine();
Console.WriteLine(" Informe um outro número inteiro ");
string dadosEntrada1 = Console.ReadLine();

try
{
    int numero = int.Parse(dadosEntrada);
    Console.WriteLine($" O número inserido está de acordo {numero} ");
    int numero1 = int.Parse(dadosEntrada1);
    Console.WriteLine($" O número inserido está de acordo {numero1} ");
    Console.WriteLine($" A divisão dos números inteiros inseridos é {numero / numero1}");
   // Console.WriteLine($" O resto da divisão entre os numeros é  {numero & numero1}");
}
catch (FormatException)
{
    Console.WriteLine("Erro: O número informado não parece um número inteiro válido ");
}
catch (OverflowException)
{
    Console.WriteLine("Erro : O número informado é superior ao permitido para esse tipo");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro : Operação não permitida (divisão por zero)");
}
finally
{
    Console.WriteLine(" Final da operação da entrada de dados");
