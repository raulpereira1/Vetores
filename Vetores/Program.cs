using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seus dados: ");
            Console.WriteLine("--------");
            Console.WriteLine("Digite seu nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            string age = Console.ReadLine();
            Console.WriteLine("Digite sua localização:");
            string location = Console.ReadLine();
            string user = name + " " + age + " " + location;
            Console.WriteLine("----------");
            Console.WriteLine(user);
            
            Console.WriteLine("----------");
            Console.WriteLine("Digite os membros de sua casa utilizando espaço como separador");
            
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);   

        }
    }
}