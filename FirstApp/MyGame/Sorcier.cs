public class Sorcier : Personnage
{
    public Sorcier(string nom) : base(nom)
    {
        pointsDeVie = 80;
        degatsMin = 10;
        degatsMax = 25;
    }
}