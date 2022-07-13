using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicFiveWebAppMcCoy.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics"},
                new Game { GameID = "paralympics", Name = "Paralympics"},
                new Game { GameID = "youth", Name = "Youth Olymic Games"}
            );

            modelBuilder.Entity<Country>().HasData(
                new
                {
                    CountryID = "canada",
                    Name = "Canada",
                    GameID = "winter",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_ca-flag.gif"
                },
                new
                {
                    CountryID = "sweden",
                    Name = "Sweden",
                    GameID = "winter",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_sw-flag.gif"
                },
                new
                {
                    CountryID = "greatBritain",
                    Name = "Great Britain",
                    GameID = "winter",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_uk-flag.gif"
                },
                new
                {
                    CountryID = "jamaica",
                    Name = "Jamaica",
                    GameID = "winter",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_jm-flag.gif"
                },
                new
                {
                    CountryID = "italy",
                    Name = "Italy",
                    GameID = "winter",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_it-flag.gif"
                },
                new
                {
                    CountryID = "japan",
                    Name = "Japan",
                    GameID = "winter",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_ja-flag.gif"
                },
                new
                {
                    CountryID = "germany",
                    Name = "Germany",
                    GameID = "summer",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_gm-flag.gif"
                },
                new
                {
                    CountryID = "china",
                    Name = "China",
                    GameID = "summer",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_ch-flag.gif"
                },
                new
                {
                    CountryID = "mexico",
                    Name = "Mexico",
                    GameID = "summer",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_mx-flag.gif-"
                },
                new
                {
                    CountryID = "brazil",
                    Name = "Brazil",
                    GameID = "summer",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_br-flag.gif"
                },
                new
                {
                    CountryID = "netherlands",
                    Name = "Netherlands",
                    GameID = "summer",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_nl-flag.gif"
                },
                new
                {
                    CountryID = "usa",
                    Name = "USA",
                    GameID = "summer",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_us-flag.gif"
                },
                new
                {
                    CountryID = "thailand",
                    Name = "Thailand",
                    GameID = "paralympics",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_th-flag.gif"
                },
                new
                {
                    CountryID = "uruguay",
                    Name = "Uruguay",
                    GameID = "paralympics",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_uy-flag.gif"
                },
                new
                {
                    CountryID = "ukraine",
                    Name = "Ukraine",
                    GameID = "paralympics",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_up-flag.gif"
                },
                new
                {
                    CountryID = "austria",
                    Name = "Austria",
                    GameID = "paralympics",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_au-flag.gif"
                },
                new
                {
                    CountryID = "pakistan",
                    Name = "Pakistan",
                    GameID = "paralympics",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_pk-flag.gif"
                },
                new
                {
                    CountryID = "zimbabwe",
                    Name = "Zimbabwe",
                    GameID = "paralympics",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_zi-flag.gif"
                },
                new
                {
                    CountryID = "france",
                    Name = "France",
                    GameID = "youth",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_fr-flag.gif"
                },
                new
                {
                    CountryID = "cyprus",
                    Name = "Cyprus",
                    GameID = "youth",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_cy-flag.gif"
                },
                new
                {
                    CountryID = "russia",
                    Name = "Russia",
                    GameID = "youth",
                    CategoryID = "indoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_rs-flag.gif"
                },
                new
                {
                    CountryID = "finland",
                    Name = "Finland",
                    GameID = "youth",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_fi-flag.gif"
                },
                new
                {
                    CountryID = "slovakia",
                    Name = "Slovakia",
                    GameID = "youth",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_lo-flag.gif"
                },
                new
                {
                    CountryID = "portugal",
                    Name = "Portugal",
                    GameID = "youth",
                    CategoryID = "outdoor",
                    FlagImage = "https://www.worldometers.info/img/flags/small/tn_po-flag.gif"
                }
            );
        }
    }
}
