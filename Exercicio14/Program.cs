// See https://aka.ms/new-console-template for more information
//Exercício 14 - Minicalculadora com método

class Program
{
    static void Main()
    {
        Console.WriteLine(" Informe um número");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(" Informe um número");
        int b = int.Parse(Console.ReadLine());
        int resultado = somar(a, b);
        Console.WriteLine($" O números inseridos e somados são : {resultado}");
    }
    static int somar(int num1, int num2)
    {
        return num1 + num2;
    }
}
