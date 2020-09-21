using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP2_Module5.BDD;
using TP2_Module5.Models;

namespace TP2_Module5.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View(Database.Instance.ListePizzas);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            PizzaCreateViewModel vm = new PizzaCreateViewModel();
            vm.Pizza = Database.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            return View(vm);
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            PizzaCreateViewModel vm = new PizzaCreateViewModel();

            vm.Pates = Database.Instance.PatesDisponibles.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            vm.Ingredients = Database.Instance.IngredientsDisponibles.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            return View(vm);
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(PizzaCreateViewModel vm)
        {
            try
            {
                if (ModelState.IsValid && ValidateVM(vm))
                {
                    Pizza pizza = vm.Pizza;

                    vm.Pizza.Pate = Database.Instance.PatesDisponibles.FirstOrDefault(x => x.Id == vm.IdPate);

                    pizza.Ingredients = Database.Instance.IngredientsDisponibles.Where(
                        x => vm.IdIngredients.Contains(x.Id))
                        .ToList();

                    // Insuffisant
                    //pizza.Id = FakeDb.Instance.Pizzas.Count + 1;

                    pizza.Id = Database.Instance.ListePizzas.Count == 0 ? 1 : Database.Instance.ListePizzas.Max(x => x.Id) + 1;

                    Database.Instance.ListePizzas.Add(pizza);

                    return RedirectToAction("Index");
                }
                else
                {
                    vm.Pates = Database.Instance.PatesDisponibles.Select(
                        x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                        .ToList();

                    vm.Ingredients = Database.Instance.IngredientsDisponibles.Select(
                        x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                        .ToList();

                    return View(vm);
                }
            }
            catch
            {
                vm.Pates = Database.Instance.PatesDisponibles.Select(
               x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
               .ToList();

                vm.Ingredients = Database.Instance.IngredientsDisponibles.Select(
                    x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                    .ToList();

                return View(vm);
            }
        }

        private bool ValidateVM(PizzaCreateViewModel vm)
        {
            bool result = true;
            return result;
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            PizzaCreateViewModel vm = new PizzaCreateViewModel();

            vm.Pates = Database.Instance.PatesDisponibles.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            vm.Ingredients = Database.Instance.IngredientsDisponibles.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            vm.Pizza = Database.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);

            if (vm.Pizza.Pate != null)
            {
                vm.IdPate = vm.Pizza.Pate.Id;
            }

            if (vm.Pizza.Ingredients.Any())
            {
                vm.IdIngredients = vm.Pizza.Ingredients.Select(x => x.Id).ToList();
            }

            return View(vm);
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(PizzaCreateViewModel vm)
        {
            try
            {
                Pizza pizza = Database.Instance.ListePizzas.FirstOrDefault(x => x.Id == vm.Pizza.Id);
                pizza.Nom = vm.Pizza.Nom;
                pizza.Pate = Database.Instance.PatesDisponibles.FirstOrDefault(x => x.Id == vm.IdPate);
                pizza.Ingredients = Database.Instance.IngredientsDisponibles.Where(x => vm.IdIngredients.Contains(x.Id)).ToList();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            PizzaCreateViewModel vm = new PizzaCreateViewModel();
            vm.Pizza = Database.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            return View(vm);
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            Pizza pizza = null;
            try
            {
                pizza = Database.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
                Database.Instance.ListePizzas.Remove(pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(pizza);
            }
        }
    }
}
