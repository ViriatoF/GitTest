using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnGit
{
    public class Person
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Adresse { get; set; }

        public Person(int aIdentifiant, string aNom, string aPrenom, int aAge, string aAdresse)
        {
            this.Identifiant = aIdentifiant;
            this.Nom = aNom;
            this.Prenom = aPrenom;
            this.Age = aAge;
            this.Adresse = aAdresse;
        }
    }
}
