class Program
    {
        static void Main(string[] args){
        {
            Personne personne1 = new Personne("mine","mobs");
            Personne personne2 = new Personne("mine","mobs");
            Console.WriteLine(personne1.Equals(personne2));
        }
}