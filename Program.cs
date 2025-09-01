using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        string input = Console.ReadLine(); // lê o texto que o usuário digitou

        // Convertendo o texto para número inteiro
        int idade;
        bool sucesso = int.TryParse(input, out idade);

        if (!sucesso)
        {
            Console.WriteLine("Por favor, digite um número válido.");
            return; // encerra o programa
        }

        if (idade > 2)
        {
            Console.WriteLine("Você é adulto");
        }
        else if (idade < 2)
        {
            Console.WriteLine(" Léo você é potudo.");
        }
        else
        {
            Console.WriteLine("Você tem exatamente 2 anos");
        }
    }
}
