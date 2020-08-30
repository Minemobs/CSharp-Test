using System;
namespace FirstApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Personne personne = new Personne();
            personne.Age = 15;
            Console.WriteLine(personne.Age);
        }
    }
}