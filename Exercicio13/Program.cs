// See https://aka.ms/new-console-template for more information
//Exercício 13 -  Média de duas Provas

Console.WriteLine("Informe a nota da primeira prova ");
var nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a nota da segunda prova ");
var nota2 = int.Parse(Console.ReadLine());
var media = (nota1 + nota2) / 2; 

Console.WriteLine("A primeira nota do aluno  foi :" + nota1.ToString("F2") + Environment.NewLine + "A Segunda nota do aluno foi :" + nota2.ToString("F2") + Environment.NewLine +
"A média entre as notas apresentadas do aluno foi " + media.ToString("F2"));

