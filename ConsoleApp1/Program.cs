using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static int test;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world !");/*Ecriture sur la console avec retour à la ligne, Console.Write écrit dans la sortie console sans retour chariot*/

            Console.ReadKey(); /*Permet de forcer le système à attendre l'appui sur une touche par l'utilisateur et donc de garder la console ouverte*/
        }
        public int MyProperty { get => MyProperty; set => MyProperty = value; }

        public int MyProperty1 { get; set; }
    }

}
