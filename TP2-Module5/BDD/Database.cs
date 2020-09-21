using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP2_Module5.BDD;

namespace TP2_Module5.BDD
{
    public class Database
    {

        private static readonly Lazy<Database> lazy =
            new Lazy<Database>(() => new Database());

        /// <summary>
        /// FakeDb singleton access.
        /// </summary>
        public static Database Instance { get { return lazy.Value; } }

        private Database()
        {
            this.ListePizzas = new List<Pizza>();
            this.PatesDisponibles = this.InitPatesDisponibles();
            this.IngredientsDisponibles = this.InitIngredientsDisponibles();
        }

        public List<Pizza> ListePizzas { get; private set; }
        public List<Pate> PatesDisponibles { get; private set; }
        public List<Ingredient> IngredientsDisponibles { get; private set; }


        private List<Ingredient> InitIngredientsDisponibles()
        {
            List<Ingredient> result = new List<Ingredient>();
            result.Add(new Ingredient { Id = 1, Nom = "Mozzarella" });
            result.Add(new Ingredient { Id = 2, Nom = "Jambon" });
            result.Add(new Ingredient { Id = 3, Nom = "Tomate" });
            result.Add(new Ingredient { Id = 4, Nom = "Oignon" });
            result.Add(new Ingredient { Id = 5, Nom = "Cheddar" });
            result.Add(new Ingredient { Id = 6, Nom = "Saumon" });
            result.Add(new Ingredient { Id = 7, Nom = "Champignon" });
            result.Add(new Ingredient { Id = 8, Nom = "Poulet" });

            return result;
        }

        private List<Pate> InitPatesDisponibles()
        {
            List<Pate> result = new List<Pate>();
            result.Add(new Pate { Id = 1, Nom = "Pate fine, base crème" });
            result.Add(new Pate { Id = 2, Nom = "Pate fine, base tomate" });
            result.Add(new Pate { Id = 3, Nom = "Pate épaisse, base crème" });
            result.Add(new Pate { Id = 4, Nom = "Pate épaisse, base tomate" });

            return result;
        }

        private List<Pizza> InitPizzas ()
        {
            List<Pizza> result = new List<Pizza>();
            return result;
        }
    }
}