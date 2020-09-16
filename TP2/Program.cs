using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Entities;

namespace TP2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InitialiserDatas();

            //var prenomDesAuteursDontNomCommenceParG = from auteur in ListeAuteurs where (auteur.Nom.StartsWith('G') select auteur.Prenom;
            var prenomDesAuteursDontNomCommenceParG = ListeAuteurs.Where(x => x.Nom.StartsWith("G"));

            foreach(Auteur auteur in prenomDesAuteursDontNomCommenceParG)
            {
                Console.WriteLine(auteur.Prenom);
            }

            //var auteurAyantEcritLePlusDeLivre = ListeLivres.GroupBy(x => x.Auteur)
            //    .Select(x => x.OrderByDescending(x => x.ListeLivres.Livre.Count)
            //    .First()
            //    );

            //var nombreMoyenDePagesParLivre = ListeLivres.Select(x => x.NbPages);
            //var nombreMoyenDePagesParLivreParAuteur = ListeLivres.GroupBy(x => x.Auteur).Average(x => x.NbPages); 

            foreach (IGrouping<Auteur,Livre> item in ListeLivres.GroupBy(x=>x.Auteur))
            {
                var moyennePage = item.Average(x => x.NbPages);
                Console.WriteLine(moyennePage);
            }

            


            var titreLivreAvecLePlusDePages = ListeLivres.OrderByDescending(x => x.NbPages).First().Titre;

            Console.WriteLine(titreLivreAvecLePlusDePages);


            
            foreach(IGrouping<Auteur,Facture> item in ListeAuteurs.SelectMany(x => x.Factures).GroupBy(x => x.Auteur))
            {
                var moyenneFacture = item.Average(x => x.Montant);
                Console.WriteLine(moyenneFacture);
            }






            Console.ReadKey();
        }
        //var query = tapesTable.GroupBy(x => x.Tape)
        //              .Select(x => x.OrderByDescending(t => t.Count)
        //                            .First());




        private static List<Auteur> ListeAuteurs = new List<Auteur>();
        private static List<Livre> ListeLivres = new List<Livre>();

        private static void InitialiserDatas()
        {
            ListeAuteurs.Add(new Auteur("GROUSSARD", "Thierry"));
            ListeAuteurs.Add(new Auteur("GABILLAUD", "Jérôme"));
            ListeAuteurs.Add(new Auteur("HUGON", "Jérôme"));
            ListeAuteurs.Add(new Auteur("ALESSANDRI", "Olivier"));
            ListeAuteurs.Add(new Auteur("de QUAJOUX", "Benoit"));

            ListeLivres.Add(new Livre(1, "C# 4", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 533));
            ListeLivres.Add(new Livre(2, "VB.NET", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 539));
            ListeLivres.Add(new Livre(3, "SQL Server 2008", "SQL, Transact SQL", ListeAuteurs.ElementAt(1), 311));
            ListeLivres.Add(new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", ListeAuteurs.ElementAt(3), 544));
            ListeLivres.Add(new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", ListeAuteurs.ElementAt(2), 452));
            ListeLivres.Add(new Livre(6, "Java 7", "les fondamentaux du langage", ListeAuteurs.ElementAt(0), 416));
            ListeLivres.Add(new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", ListeAuteurs.ElementAt(1), 216));

            ListeAuteurs.ElementAt(0).addFacture(new Facture(3500, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3200, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(1).addFacture(new Facture(4000, ListeAuteurs.ElementAt(1)));
            ListeAuteurs.ElementAt(2).addFacture(new Facture(4200, ListeAuteurs.ElementAt(2)));
            ListeAuteurs.ElementAt(3).addFacture(new Facture(3700, ListeAuteurs.ElementAt(3)));
        }
    }
}
