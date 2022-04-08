using System;

namespace Aula8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Cachorro apolo = new Cachorro("Apólo", "branco", 2, 5.1);
            Cachorro maggie = new Cachorro("Maggie", "caramelo e branco", 8, 8.2);
            Cachorro tobby = new Cachorro("Tobby", "marrom", 4, 6.7);
            Cachorro luz = new Cachorro("Luz", "branca e marrom", 6, 12.3);

            Console.WriteLine($"Cachorro 1 é o {apolo.Nome} de cor {apolo.Cor} com {apolo.Idade} anos e pesa {apolo.Peso}Kg");

            Console.WriteLine($"Cachorro 2 é a {maggie.Nome} de cor {maggie.Cor} com {maggie.Idade} anos e pesa {maggie.Peso}Kg");

            Console.WriteLine($"Cachorro 3 é o {tobby.Nome} de cor {tobby.Cor} com {tobby.Idade} anos e pesa {tobby.Peso}Kg");

            Console.WriteLine($"Cachorro 4 é a {luz.Nome} de cor {luz.Cor} com {luz.Idade} anos e pesa {luz.Peso}Kg");

        }
    }
}
