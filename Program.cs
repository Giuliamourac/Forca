using System;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        { 

        Console.WriteLine("Digite a palavra secreta.");
        string Senha = Console.ReadLine().ToUpper();

        Console.WriteLine("Digite uma letra.");
        string Letra = Console.ReadLine().ToUpper();

        bool Existe = Senha.Contains(Letra);
        Console.WriteLine($"A letra \"{Letra}\" existe na palavra secreta => {Existe}");

        }
    }
}