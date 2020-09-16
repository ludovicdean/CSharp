using Démonstration2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démonstration2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Age = 10;
            p1.Nom = "luyglu";
            p1.Prenom = "mliygluytf";

            Console.WriteLine(p1);

            Personne p2 = new Personne { Age = 12, Nom = "kluyfktfl", Prenom = "jhyfktgfluygktydj" };

            Console.WriteLine(p2);

            Personne p3 = new Personne("luyftrydr", "louyfktuyf", 62);

            Console.WriteLine(p3);

            Console.ReadKey();

            p2 = p3; /*Si on veut copier un objet on doit réellement faire une copie. Si on fait ceci, on modifie les 2 simultanément*/

        }
    }
}
