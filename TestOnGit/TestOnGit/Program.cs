using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person(425, "Marfle", "Charles", 35, "12 rue de la troupenisse");
            Person Person2 = new Person(426, "Plouckt", "Gonzague", 29, "66 rue de la perche dorée");
            
            Console.WriteLine(" Id : " +Person1.Identifiant+ "\n Nom : " +Person1.Nom+ "\n Prénom : " +Person1.Prenom+ "\n Age : " +Person1.Age+ "\n Adresse : " +Person1.Adresse);
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine(" Id : " +Person2.Identifiant+ "\n Nom : " +Person2.Nom+ "\n Prénom : " +Person2.Prenom+ "\n Age : " +Person2.Age+ "\n Adresse : " +Person2.Adresse);
            Console.ReadLine();
        }
    }
}
