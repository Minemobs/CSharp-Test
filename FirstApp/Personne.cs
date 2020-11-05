using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstApp
{
    class Personne : IEquatable<Personne>
    {

        public string Nom {get; set;}
        public string Prenom {get; set;}

        public Personne(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public bool Equals(Personne personne)
        {
            return this.Nom == personne.Nom && this.Prenom == personne.Prenom;
        }
    }
}