using System;
namespace FirstApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Personne personne = new Personne();
            personne.Age = 105;
            Console.WriteLine(personne.Age + "ans");
        }
    }
}