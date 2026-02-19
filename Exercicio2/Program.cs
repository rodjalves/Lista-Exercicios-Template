// See https://aka.ms/new-console-template for more information
//  Exercício 02 - Antecessor e Sucessor
Console.WriteLine("Insira um número inteiro no campo abaixo");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("O numero inserido foi" + numero1);
Console.WriteLine($"O número antecessor ao número inserido é:  { numero1 - 1}"); 
Console.WriteLine($"O  número sucessor ao informado pelo usuário é:  { numero1 + 1}");
