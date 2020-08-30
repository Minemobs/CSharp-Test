using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Entite
{
    protected string nom;
    protected bool estMort = false;
    protected int pointsDeVie;
    protected int degatsMin;
    protected int degatsMax;
    protected Random random = new Random();

    public Entite(string nom){
        this.nom = nom;
    }

    public void Attaquer(Entite uneEntite){
        
    }

    protected void perdrePointsDeVie(int pointsDeVie){

    }

    public bool EstMort(){
        return this.estMort;
    }

}