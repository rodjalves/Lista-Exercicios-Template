// See https://aka.ms/new-console-template for more information
// Exercício 04 -  Calculadora Simples
using System;

Console.WriteLine(" Informe um número ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine(" Informe outro número");
int numero1 = int.Parse(Console.ReadLine());
var soma = numero + numero1;
var subtração = numero - numero1;
var multiplicação = numero * numero1;
var divisão =  numero / numero1;
//int opção;

Console.WriteLine(" Informe a operação que deseja fazer: 1 para somar, 2 para subtrair, 3 para  multiplicar ou  4 para dividir ");
int opção = int.Parse(Console.ReadLine());

if (opção == 1)
{
   Console.WriteLine(" A soma dos valores informados é: " + soma);
}
if (opção == 2)
{
    Console.WriteLine(" A subtração dos valores informados é: " + subtração);
}
if (opção == 3)
{
    Console.WriteLine(" A multipliação dos valores informados é: " + multiplicação);
}
if (opção == 4)
{
    Console.WriteLine(" A divisão dos valores informados é: " + divisão);
}

else
    Console.WriteLine(" Opção informada inexistente");

