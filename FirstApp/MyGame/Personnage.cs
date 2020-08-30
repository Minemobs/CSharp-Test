using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Personnage : Entite
{
    private int niveau;
    private int experience;

    public Personnage(string nom) : base(nom)
    {
        this.nom = nom;
        niveau = 1;
        experience = 0;
    }
    
    public void gagnerExp(int experience)
    {

    }

    public double experienceRequise()
    {

    }

    public string Caracteristiques()
    {
        return this.nom + "\n" +
        "Points de vie : " + pointsDeVie + "\n" +
        "Niveau : " + niveau + "\n" +
        "Points d'expérience : (" + experience + "/" + experienceRequise() + ")\n" +
        "Dégats : [" + degatsMin + ";" + degatsMax + "]";
    }

}