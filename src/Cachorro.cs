using System;

namespace Aula8CSharp
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Cachorro(string _nome, string _cor, int _idade, double _peso)
        {
            Nome = _nome;
            Cor = _cor;
            Idade = _idade;
            Peso = _peso;
        
        }
        public void roer(string ossinho)
        {
            Console.WriteLine($"Estou roendo {ossinho}");
        }
        public void dormir()
        {
            Console.WriteLine("ZZzzzzZZzzZzZZz...");
        }
        public string latir()
        {
            return "Au au au au au au au au";
        }
        
    }
}