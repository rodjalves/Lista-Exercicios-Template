// See https://aka.ms/new-console-template for more information
Exercício 06 - Conversão de temperatura
Console.WriteLine(" Informe a temperatura em graus Celsius");
var temperatura = int.Parse(Console.ReadLine());
var farenheit = (temperatura * 9 / 5) + 32;

Console.WriteLine(" A temperatura convertida para Fahrenheit é " + farenheit);
