using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicFiveWebAppMcCoy.Models
{
    public class CountryViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveCat { get; set; }
        public string ActiveGam { get; set; }

        //make next two properties standard properties so the setter can make the first item in each list "all"
        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0,
                    new Category
                    {
                        CategoryID = "all",
                        Name = "all"
                    });
            }
        }
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game
                    {
                        GameID = "all",
                        Name = "all"
                    });
            }
        }
        //methods to help view determine active link
        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";
        public string CheckActiveGam(string g) =>
            g.ToLower() == ActiveGam.ToLower() ? "active" : "";

    }
}
