using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démonstration2.Entities
{
    public class Personne
    {
        private static int globalId = 0;
        private int id;
        private string prenom;
        private String nom;
        private int age;

        public int Id { get => id; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }

        public Personne()
        {
            globalId++;
            id = globalId;
        }

        public Personne(string prenom, string nom, int age) : this()
        {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",this.Id, this.Age,this.Nom,this.Prenom);
        }
    }
}
