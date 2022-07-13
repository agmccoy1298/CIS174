using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopicFiveWebAppMcCoy.Models;

namespace TopicFiveWebAppMcCoy.Controllers
{
    public class WeekSixTwoController : Controller
    {
        private CountryContext context { get; set; }


        public WeekSixTwoController(CountryContext ctx)
        {
            context = ctx;
        }
        //public ViewResult SixPointTwo(string activeGam = "all", string activeCat = "all")
        //{
           
        //    //store active categories and games in view bag 
        //    ViewBag.ActiveGame = activeGam;
        //    ViewBag.ActiveCategory = activeCat;

        //    //get list of games and categories from database
        //    List<Category> categories = context.Categories.ToList();
        //    List<Game> games = context.Games.ToList();

        //    //insert default "all" Value at front of each list
        //    categories.Insert(0, new Category { CategoryID = "all", Name = "All" });
        //    games.Insert(0, new Game { GameID = "all", Name = "All" });

        //    //stor lists in view bag
        //    ViewBag.Categories = categories;
        //    ViewBag.Games = games;

        //    //get countries - filter by Game and Category
        //    IQueryable<Country> query = context.Countries;
        //    if (activeCat != "all")
        //        query = query.Where(t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
        //    if (activeGam != "all")
        //        query = query.Where(t => t.Game.GameID.ToLower() == activeGam.ToLower());

        //    //pass countries to view as model
        //    var countries = query.ToList();
        //    return View(countries);

        //}
        public ViewResult SixPointTwo(string activeGam = "all", string activeCat = "all")
        {
            var model = new CountryViewModel
            {
                ActiveCat = activeCat,
                ActiveGam = activeGam,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList()
            };
            IQueryable<Country> query = context.Countries;
            
            if (activeGam != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGam.ToLower());
            if (activeCat != "all")
                            query = query.Where(t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
            //pass countries to view as model
            model.Countries = query.ToList();
            return View(model);
        }
    }
    
}
