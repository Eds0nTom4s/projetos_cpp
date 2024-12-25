using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um nome : ");
            var n = ""; 
            n = Console.ReadLine();
            
            Console.WriteLine("Digite a sua idade");

            int idade = 0;

            try
            {
                idade = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Aconteceu alguma coisa " + e.Message);
                
            }
            
            
            int dataDeNascimento = 2024 - idade;

            Console.WriteLine("Seu nome: " + n);
            Console.WriteLine("Sua idade: "+ idade);

            Console.WriteLine("Ano de Nascimento: " + dataDeNascimento);
        }
    }
}