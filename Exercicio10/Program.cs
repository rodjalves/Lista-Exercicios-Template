// See https://aka.ms/new-console-template for more information
// Exercício 10 Salário Mensal

Console.WriteLine(" Qual o valor pago pela hora trabalhada?");
var valorHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(" Quantas horas foram trabalhadas no mês?");
var horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Durante o mês foram trabalhadas {horasTrabalhadas} horas, então o valor a ser pago ao trabalhador é R$ {horasTrabalhadas*valorHora}");

