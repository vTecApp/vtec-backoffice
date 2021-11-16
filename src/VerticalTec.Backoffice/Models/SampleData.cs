using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerticalTec.Backoffice.Models {

    public class SampleOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public DateTime Date {get;set;}
        public string Region { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public decimal Amount { get; set; }
    }

    static class SampleData {
        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderId = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderId = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                ShipCountry = "Germany",
                ShipCity = "Münster",
                CustomerName = "Karin Josephs"
            },
            new SampleOrder {
                OrderId = 10250,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderId = 10251,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "France",
                ShipCity = "Lyon",
                CustomerName = "Mary Saveley"
            },
            new SampleOrder {
                OrderId = 10252,
                OrderDate = new DateTime(1996, 7, 9),
                ShipCountry = "Belgium",
                ShipCity = "Charleroi",
                CustomerName = "Pascale Cartrain"
            },
            new SampleOrder {
                OrderId = 10253,
                OrderDate = new DateTime(1996, 7, 10),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderId = 10254,
                OrderDate = new DateTime(1996, 7, 11),
                ShipCountry = "Switzerland",
                ShipCity = "Bern",
                CustomerName = "Yang Wang"
            },
            new SampleOrder {
                OrderId = 10255,
                OrderDate = new DateTime(1996, 7, 12),
                ShipCountry = "Switzerland",
                ShipCity = "Genève",
                CustomerName = "Michael Holz"
            },
            new SampleOrder {
                OrderId = 10256,
                OrderDate = new DateTime(1996, 7, 15),
                ShipCountry = "Brazil",
                ShipCity = "Resende",
                CustomerName = "Paula Parente"
            },
            new SampleOrder {
                OrderId = 10257,
                OrderDate = new DateTime(1996, 7, 16),
                ShipCountry = "Venezuela",
                ShipCity = "San Cristóbal",
                CustomerName = "Carlos Hernández"
            },
            new SampleOrder {
                OrderId = 10258,
                OrderDate = new DateTime(1996, 7, 17),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderId = 10259,
                OrderDate = new DateTime(1996, 7, 18),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Francisco Chang"
            },
            new SampleOrder {
                OrderId = 10260,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Germany",
                ShipCity = "Köln",
                CustomerName = "Henriette Pfalzheim"
            },
            new SampleOrder {
                OrderId = 10261,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderId = 10262,
                OrderDate = new DateTime(1996, 7, 22),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderId = 10263,
                OrderDate = new DateTime(1996, 7, 23),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderId = 10264,
                OrderDate = new DateTime(1996, 7, 24),
                ShipCountry = "Sweden",
                ShipCity = "Bräcke",
                CustomerName = "Maria Larsson"
            },
            new SampleOrder {
                OrderId = 10265,
                OrderDate = new DateTime(1996, 7, 25),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            },
            new SampleOrder {
                OrderId = 10266,
                OrderDate = new DateTime(1996, 7, 26),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderId = 10267,
                OrderDate = new DateTime(1996, 7, 29),
                ShipCountry = "Germany",
                ShipCity = "München",
                CustomerName = "Peter Franken"
            },
            new SampleOrder {
                OrderId = 10268,
                OrderDate = new DateTime(1996, 7, 30),
                ShipCountry = "Venezuela",
                ShipCity = "Caracas",
                CustomerName = "Manuel Pereira"
            },
            new SampleOrder {
                OrderId = 10269,
                OrderDate = new DateTime(1996, 7, 31),
                ShipCountry = "USA",
                ShipCity = "Seattle",
                CustomerName = "Karl Jablonski"
            },
            new SampleOrder {
                OrderId = 10270,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderId = 10271,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "USA",
                ShipCity = "Lander",
                CustomerName = "Art Braunschweiger"
            },
            new SampleOrder {
                OrderId = 10272,
                OrderDate = new DateTime(1996, 8, 2),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderId = 10273,
                OrderDate = new DateTime(1996, 8, 5),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderId = 10274,
                OrderDate = new DateTime(1996, 8, 6),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderId = 10275,
                OrderDate = new DateTime(1996, 8, 7),
                ShipCountry = "Italy",
                ShipCity = "Bergamo",
                CustomerName = "Giovanni Rovelli"
            },
            new SampleOrder {
                OrderId = 10276,
                OrderDate = new DateTime(1996, 8, 8),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderId = 10277,
                OrderDate = new DateTime(1996, 8, 9),
                ShipCountry = "Germany",
                ShipCity = "Leipzig",
                CustomerName = "Alexander Feuer"
            },
            new SampleOrder {
                OrderId = 10278,
                OrderDate = new DateTime(1996, 8, 12),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderId = 10279,
                OrderDate = new DateTime(1996, 8, 13),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderId = 10280,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderId = 10281,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderId = 10282,
                OrderDate = new DateTime(1996, 8, 15),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderId = 10283,
                OrderDate = new DateTime(1996, 8, 16),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderId = 10284,
                OrderDate = new DateTime(1996, 8, 19),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderId = 10285,
                OrderDate = new DateTime(1996, 8, 20),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderId = 10286,
                OrderDate = new DateTime(1996, 8, 21),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderId = 10287,
                OrderDate = new DateTime(1996, 8, 22),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Janete Limeira"
            },
            new SampleOrder {
                OrderId = 10288,
                OrderDate = new DateTime(1996, 8, 23),
                ShipCountry = "Italy",
                ShipCity = "Reggio Emilia",
                CustomerName = "Maurizio Moroni"
            },
            new SampleOrder {
                OrderId = 10289,
                OrderDate = new DateTime(1996, 8, 26),
                ShipCountry = "UK",
                ShipCity = "London",
                CustomerName = "Victoria Ashworth"
            },
            new SampleOrder {
                OrderId = 10290,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Pedro Afonso"
            },
            new SampleOrder {
                OrderId = 10291,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderId = 10292,
                OrderDate = new DateTime(1996, 8, 28),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Anabela Domingues"
            },
            new SampleOrder {
                OrderId = 10293,
                OrderDate = new DateTime(1996, 8, 29),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderId = 10294,
                OrderDate = new DateTime(1996, 8, 30),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderId = 10295,
                OrderDate = new DateTime(1996, 9, 2),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderId = 10296,
                OrderDate = new DateTime(1996, 9, 3),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderId = 10297,
                OrderDate = new DateTime(1996, 9, 4),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            }
        };

        public static readonly IEnumerable<SampleOrder> SampleOrders = new[] {
            new SampleOrder {
                OrderId = 10248,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 1740,
                Date = DateTime.Parse("2013/01/06")
            },
            new SampleOrder {
                OrderId = 10249,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 850,
                Date = DateTime.Parse("2013/01/13")
            },
            new SampleOrder {
                OrderId = 10250,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2235,
                Date = DateTime.Parse("2013/01/07")
            },
            new SampleOrder {
                OrderId = 10251,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1965,
                Date = DateTime.Parse("2013/01/03")
            },
            new SampleOrder {
                OrderId = 10252,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 880,
                Date = DateTime.Parse("2013/01/10")
            },
            new SampleOrder {
                OrderId = 10253,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 5260,
                Date = DateTime.Parse("2013/01/17")
            },
            new SampleOrder {
                OrderId = 10254,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 2790,
                Date = DateTime.Parse("2013/01/21")
            },
            new SampleOrder {
                OrderId = 10255,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 3140,
                Date = DateTime.Parse("2013/01/01")
            },
            new SampleOrder {
                OrderId = 10256,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 6175,
                Date = DateTime.Parse("2013/01/24")
            },
            new SampleOrder {
                OrderId = 10257,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 4575,
                Date = DateTime.Parse("2013/01/11")
            },
            new SampleOrder {
                OrderId = 10258,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 3680,
                Date = DateTime.Parse("2013/01/12")
            },
            new SampleOrder {
                OrderId = 10259,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 2260,
                Date = DateTime.Parse("2013/01/01")
            },
            new SampleOrder {
                OrderId = 10260,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 2910,
                Date = DateTime.Parse("2013/01/26")
            },
            new SampleOrder {
                OrderId = 10261,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 8400,
                Date = DateTime.Parse("2013/01/05")
            },
            new SampleOrder {
                OrderId = 10262,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 1325,
                Date = DateTime.Parse("2013/01/14")
            },
            new SampleOrder {
                OrderId = 10263,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 3920,
                Date = DateTime.Parse("2013/01/05")
            },
            new SampleOrder {
                OrderId = 10264,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 2220,
                Date = DateTime.Parse("2013/01/15")
            },
            new SampleOrder {
                OrderId = 10265,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 940,
                Date = DateTime.Parse("2013/01/01")
            },
            new SampleOrder {
                OrderId = 10266,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1630,
                Date = DateTime.Parse("2013/01/10")
            },
            new SampleOrder {
                OrderId = 10267,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 2910,
                Date = DateTime.Parse("2013/01/23")
            },
            new SampleOrder {
                OrderId = 10268,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 2600,
                Date = DateTime.Parse("2013/01/14")
            },
            new SampleOrder {
                OrderId = 10269,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 4340,
                Date = DateTime.Parse("2013/01/26")
            },
            new SampleOrder {
                OrderId = 10270,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 6650,
                Date = DateTime.Parse("2013/01/24")
            },
            new SampleOrder {
                OrderId = 10271,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 490,
                Date = DateTime.Parse("2013/01/22")
            },
            new SampleOrder {
                OrderId = 10272,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 3390,
                Date = DateTime.Parse("2013/01/25")
            },
            new SampleOrder {
                OrderId = 10273,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 5160,
                Date = DateTime.Parse("2013/02/20")
            },
            new SampleOrder {
                OrderId = 10274,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 5750,
                Date = DateTime.Parse("2013/02/12")
            },
            new SampleOrder {
                OrderId = 10275,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2805,
                Date = DateTime.Parse("2013/02/13")
            },
            new SampleOrder {
                OrderId = 10276,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 2505,
                Date = DateTime.Parse("2013/02/09")
            },
            new SampleOrder {
                OrderId = 10277,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 930,
                Date = DateTime.Parse("2013/02/04")
            },
            new SampleOrder {
                OrderId = 10278,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 1240,
                Date = DateTime.Parse("2013/02/03")
            },
            new SampleOrder {
                OrderId = 10279,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 315,
                Date = DateTime.Parse("2013/02/04")
            },
            new SampleOrder {
                OrderId = 10280,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 2870,
                Date = DateTime.Parse("2013/02/18")
            },
            new SampleOrder {
                OrderId = 10281,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 5150,
                Date = DateTime.Parse("2013/02/18")
            },
            new SampleOrder {
                OrderId = 10282,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 2725,
                Date = DateTime.Parse("2013/02/20")
            },
            new SampleOrder {
                OrderId = 10283,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 2840,
                Date = DateTime.Parse("2013/02/04")
            },
            new SampleOrder {
                OrderId = 10284,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 5840,
                Date = DateTime.Parse("2013/02/13")
            },
            new SampleOrder {
                OrderId = 10285,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 6750,
                Date = DateTime.Parse("2013/02/11")
            },
            new SampleOrder {
                OrderId = 10286,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 1200,
                Date = DateTime.Parse("2013/02/03")
            },
            new SampleOrder {
                OrderId = 10287,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 4550,
                Date = DateTime.Parse("2013/02/08")
            },
            new SampleOrder {
                OrderId = 10288,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 6040,
                Date = DateTime.Parse("2013/02/17")
            },
            new SampleOrder {
                OrderId = 10289,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 2205,
                Date = DateTime.Parse("2013/02/08")
            },
            new SampleOrder {
                OrderId = 10290,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 990,
                Date = DateTime.Parse("2013/02/20")
            },
            new SampleOrder {
                OrderId = 10291,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 700,
                Date = DateTime.Parse("2013/02/11")
            },
            new SampleOrder {
                OrderId = 10292,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 2325,
                Date = DateTime.Parse("2013/02/15")
            },
            new SampleOrder {
                OrderId = 10293,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 930,
                Date = DateTime.Parse("2013/02/21")
            },
            new SampleOrder {
                OrderId = 10294,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 1560,
                Date = DateTime.Parse("2013/02/04")
            },
            new SampleOrder {
                OrderId = 10295,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 1740,
                Date = DateTime.Parse("2013/03/04")
            },
            new SampleOrder {
                OrderId = 10296,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 3575,
                Date = DateTime.Parse("2013/03/20")
            },
            new SampleOrder {
                OrderId = 10297,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 4500,
                Date = DateTime.Parse("2013/03/04")
            },
            new SampleOrder {
                OrderId = 10298,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1605,
                Date = DateTime.Parse("2013/03/17")
            },
            new SampleOrder {
                OrderId = 10299,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 800,
                Date = DateTime.Parse("2013/03/21")
            },
            new SampleOrder {
                OrderId = 10300,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 640,
                Date = DateTime.Parse("2013/03/08")
            },
            new SampleOrder {
                OrderId = 10301,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 735,
                Date = DateTime.Parse("2013/03/19")
            },
            new SampleOrder {
                OrderId = 10302,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 2520,
                Date = DateTime.Parse("2013/03/20")
            },
            new SampleOrder {
                OrderId = 10303,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 6675,
                Date = DateTime.Parse("2013/03/18")
            },
            new SampleOrder {
                OrderId = 10304,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 3625,
                Date = DateTime.Parse("2013/03/25")
            },
            new SampleOrder {
                OrderId = 10305,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 1200,
                Date = DateTime.Parse("2013/03/07")
            },
            new SampleOrder {
                OrderId = 10306,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 2000,
                Date = DateTime.Parse("2013/03/07")
            },
            new SampleOrder {
                OrderId = 10307,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 1410,
                Date = DateTime.Parse("2013/03/10")
            },
            new SampleOrder {
                OrderId = 10308,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 2700,
                Date = DateTime.Parse("2013/03/19")
            },
            new SampleOrder {
                OrderId = 10309,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 5950,
                Date = DateTime.Parse("2013/03/24")
            },
            new SampleOrder {
                OrderId = 10310,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 5120,
                Date = DateTime.Parse("2013/03/08")
            },
            new SampleOrder {
                OrderId = 10311,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 1980,
                Date = DateTime.Parse("2013/03/17")
            },
            new SampleOrder {
                OrderId = 10312,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 1110,
                Date = DateTime.Parse("2013/03/08")
            },
            new SampleOrder {
                OrderId = 10313,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 980,
                Date = DateTime.Parse("2013/03/21")
            },
            new SampleOrder {
                OrderId = 10314,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 5460,
                Date = DateTime.Parse("2013/03/19")
            },
            new SampleOrder {
                OrderId = 10315,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 3800,
                Date = DateTime.Parse("2013/03/12")
            },
            new SampleOrder {
                OrderId = 10316,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 2610,
                Date = DateTime.Parse("2013/03/04")
            },
            new SampleOrder {
                OrderId = 10317,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 3080,
                Date = DateTime.Parse("2013/03/22")
            },
            new SampleOrder {
                OrderId = 10318,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 2010,
                Date = DateTime.Parse("2013/03/23")
            },
            new SampleOrder {
                OrderId = 10319,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 1200,
                Date = DateTime.Parse("2013/03/04")
            },
            new SampleOrder {
                OrderId = 10320,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 7680,
                Date = DateTime.Parse("2013/04/15")
            },
            new SampleOrder {
                OrderId = 10321,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 1325,
                Date = DateTime.Parse("2013/04/07")
            },
            new SampleOrder {
                OrderId = 10322,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2835,
                Date = DateTime.Parse("2013/04/10")
            },
            new SampleOrder {
                OrderId = 10323,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 3660,
                Date = DateTime.Parse("2013/04/10")
            },
            new SampleOrder {
                OrderId = 10324,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 390,
                Date = DateTime.Parse("2013/04/12")
            },
            new SampleOrder {
                OrderId = 10325,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 4420,
                Date = DateTime.Parse("2013/04/08")
            },
            new SampleOrder {
                OrderId = 10326,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 1755,
                Date = DateTime.Parse("2013/04/13")
            },
            new SampleOrder {
                OrderId = 10327,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 2580,
                Date = DateTime.Parse("2013/04/15")
            },
            new SampleOrder {
                OrderId = 10328,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 850,
                Date = DateTime.Parse("2013/04/01")
            },
            new SampleOrder {
                OrderId = 10329,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 2825,
                Date = DateTime.Parse("2013/04/10")
            },
            new SampleOrder {
                OrderId = 10330,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 540,
                Date = DateTime.Parse("2013/04/06")
            },
            new SampleOrder {
                OrderId = 10331,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 1520,
                Date = DateTime.Parse("2013/04/08")
            },
            new SampleOrder {
                OrderId = 10332,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 8760,
                Date = DateTime.Parse("2013/04/26")
            },
            new SampleOrder {
                OrderId = 10333,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 1110,
                Date = DateTime.Parse("2013/04/16")
            },
            new SampleOrder {
                OrderId = 10334,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 6850,
                Date = DateTime.Parse("2013/04/19")
            },
            new SampleOrder {
                OrderId = 10335,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 1940,
                Date = DateTime.Parse("2013/04/23")
            },
            new SampleOrder {
                OrderId = 10336,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 1980,
                Date = DateTime.Parse("2013/04/21")
            },
            new SampleOrder {
                OrderId = 10337,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 3090,
                Date = DateTime.Parse("2013/04/03")
            },
            new SampleOrder {
                OrderId = 10338,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1640,
                Date = DateTime.Parse("2013/04/24")
            },
            new SampleOrder {
                OrderId = 10339,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 3585,
                Date = DateTime.Parse("2013/04/01")
            },
            new SampleOrder {
                OrderId = 10340,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1770,
                Date = DateTime.Parse("2013/04/01")
            },
            new SampleOrder {
                OrderId = 10341,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 4005,
                Date = DateTime.Parse("2013/04/04")
            },
            new SampleOrder {
                OrderId = 10342,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 2870,
                Date = DateTime.Parse("2013/04/02")
            },
            new SampleOrder {
                OrderId = 10343,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 960,
                Date = DateTime.Parse("2013/04/20")
            },
            new SampleOrder {
                OrderId = 10344,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 8640,
                Date = DateTime.Parse("2013/05/14")
            },
            new SampleOrder {
                OrderId = 10345,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 5450,
                Date = DateTime.Parse("2013/05/24")
            },
            new SampleOrder {
                OrderId = 10346,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2535,
                Date = DateTime.Parse("2013/05/07")
            },
            new SampleOrder {
                OrderId = 10347,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1155,
                Date = DateTime.Parse("2013/05/20")
            },
            new SampleOrder {
                OrderId = 10348,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 3140,
                Date = DateTime.Parse("2013/05/18")
            },
            new SampleOrder {
                OrderId = 10349,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 2260,
                Date = DateTime.Parse("2013/05/19")
            },
            new SampleOrder {
                OrderId = 10350,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 1215,
                Date = DateTime.Parse("2013/05/23")
            },
            new SampleOrder {
                OrderId = 10351,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 1210,
                Date = DateTime.Parse("2013/05/08")
            },
            new SampleOrder {
                OrderId = 10352,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 875,
                Date = DateTime.Parse("2013/05/25")
            },
            new SampleOrder {
                OrderId = 10353,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 5400,
                Date = DateTime.Parse("2013/05/03")
            },
            new SampleOrder {
                OrderId = 10354,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 5940,
                Date = DateTime.Parse("2013/05/25")
            },
            new SampleOrder {
                OrderId = 10355,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 4700,
                Date = DateTime.Parse("2013/05/03")
            },
            new SampleOrder {
                OrderId = 10356,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 5520,
                Date = DateTime.Parse("2013/05/12")
            },
            new SampleOrder {
                OrderId = 10357,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 9210,
                Date = DateTime.Parse("2013/05/22")
            },
            new SampleOrder {
                OrderId = 10358,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 7950,
                Date = DateTime.Parse("2013/05/12")
            },
            new SampleOrder {
                OrderId = 10359,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 3740,
                Date = DateTime.Parse("2013/05/24")
            },
            new SampleOrder {
                OrderId = 10360,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 990,
                Date = DateTime.Parse("2013/05/02")
            },
            new SampleOrder {
                OrderId = 10361,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 3190,
                Date = DateTime.Parse("2013/05/03")
            },
            new SampleOrder {
                OrderId = 10362,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 2430,
                Date = DateTime.Parse("2013/05/11")
            },
            new SampleOrder {
                OrderId = 10363,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 7380,
                Date = DateTime.Parse("2013/06/15")
            },
            new SampleOrder {
                OrderId = 10364,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 4475,
                Date = DateTime.Parse("2013/06/08")
            },
            new SampleOrder {
                OrderId = 10365,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 1290,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10366,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 2250,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10367,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 350,
                Date = DateTime.Parse("2013/06/22")
            },
            new SampleOrder {
                OrderId = 10368,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 5480,
                Date = DateTime.Parse("2013/06/24")
            },
            new SampleOrder {
                OrderId = 10369,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 2355,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10370,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 1960,
                Date = DateTime.Parse("2013/06/23")
            },
            new SampleOrder {
                OrderId = 10371,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 4125,
                Date = DateTime.Parse("2013/06/06")
            },
            new SampleOrder {
                OrderId = 10372,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 7925,
                Date = DateTime.Parse("2013/06/12")
            },
            new SampleOrder {
                OrderId = 10373,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 1120,
                Date = DateTime.Parse("2013/06/22")
            },
            new SampleOrder {
                OrderId = 10374,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 5100,
                Date = DateTime.Parse("2013/06/01")
            },
            new SampleOrder {
                OrderId = 10375,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 1500,
                Date = DateTime.Parse("2013/06/25")
            },
            new SampleOrder {
                OrderId = 10376,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 5130,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10377,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 2475,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10378,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 2100,
                Date = DateTime.Parse("2013/06/06")
            },
            new SampleOrder {
                OrderId = 10379,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 3570,
                Date = DateTime.Parse("2013/06/10")
            },
            new SampleOrder {
                OrderId = 10380,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 550,
                Date = DateTime.Parse("2013/06/02")
            },
            new SampleOrder {
                OrderId = 10381,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 2850,
                Date = DateTime.Parse("2013/06/26")
            },
            new SampleOrder {
                OrderId = 10382,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 4280,
                Date = DateTime.Parse("2013/06/19")
            },
            new SampleOrder {
                OrderId = 10383,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 1460,
                Date = DateTime.Parse("2013/06/17")
            },
            new SampleOrder {
                OrderId = 10384,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 960,
                Date = DateTime.Parse("2013/06/17")
            },
            new SampleOrder {
                OrderId = 10385,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1520,
                Date = DateTime.Parse("2013/06/03")
            },
            new SampleOrder {
                OrderId = 10386,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 6750,
                Date = DateTime.Parse("2013/06/21")
            },
            new SampleOrder {
                OrderId = 10387,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 7260,
                Date = DateTime.Parse("2013/07/14")
            },
            new SampleOrder {
                OrderId = 10388,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 2450,
                Date = DateTime.Parse("2013/07/11")
            },
            new SampleOrder {
                OrderId = 10389,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 3540,
                Date = DateTime.Parse("2013/07/02")
            },
            new SampleOrder {
                OrderId = 10390,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1950,
                Date = DateTime.Parse("2013/07/03")
            },
            new SampleOrder {
                OrderId = 10391,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 360,
                Date = DateTime.Parse("2013/07/07")
            },
            new SampleOrder {
                OrderId = 10392,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 4500,
                Date = DateTime.Parse("2013/07/03")
            },
            new SampleOrder {
                OrderId = 10393,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 4575,
                Date = DateTime.Parse("2013/07/21")
            },
            new SampleOrder {
                OrderId = 10394,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 2310,
                Date = DateTime.Parse("2013/07/18")
            },
            new SampleOrder {
                OrderId = 10395,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 7500,
                Date = DateTime.Parse("2013/07/04")
            },
            new SampleOrder {
                OrderId = 10396,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 3575,
                Date = DateTime.Parse("2013/07/23")
            },
            new SampleOrder {
                OrderId = 10397,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 760,
                Date = DateTime.Parse("2013/07/01")
            },
            new SampleOrder {
                OrderId = 10398,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 2400,
                Date = DateTime.Parse("2013/07/11")
            },
            new SampleOrder {
                OrderId = 10399,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 3330,
                Date = DateTime.Parse("2013/07/04")
            },
            new SampleOrder {
                OrderId = 10400,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 3480,
                Date = DateTime.Parse("2013/07/23")
            },
            new SampleOrder {
                OrderId = 10401,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 4875,
                Date = DateTime.Parse("2013/07/11")
            },
            new SampleOrder {
                OrderId = 10402,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 4980,
                Date = DateTime.Parse("2013/07/19")
            },
            new SampleOrder {
                OrderId = 10403,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 2580,
                Date = DateTime.Parse("2013/07/04")
            },
            new SampleOrder {
                OrderId = 10404,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 2650,
                Date = DateTime.Parse("2013/07/16")
            },
            new SampleOrder {
                OrderId = 10405,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1190,
                Date = DateTime.Parse("2013/07/02")
            },
            new SampleOrder {
                OrderId = 10406,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 960,
                Date = DateTime.Parse("2013/07/26")
            },
            new SampleOrder {
                OrderId = 10407,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 3600,
                Date = DateTime.Parse("2013/08/08")
            },
            new SampleOrder {
                OrderId = 10408,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 2250,
                Date = DateTime.Parse("2013/08/01")
            },
            new SampleOrder {
                OrderId = 10409,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 1275,
                Date = DateTime.Parse("2013/08/02")
            },
            new SampleOrder {
                OrderId = 10410,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 3885,
                Date = DateTime.Parse("2013/08/14")
            },
            new SampleOrder {
                OrderId = 10411,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 1900,
                Date = DateTime.Parse("2013/08/05")
            },
            new SampleOrder {
                OrderId = 10412,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 2300,
                Date = DateTime.Parse("2013/08/09")
            },
            new SampleOrder {
                OrderId = 10413,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 2895,
                Date = DateTime.Parse("2013/08/15")
            },
            new SampleOrder {
                OrderId = 10414,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 350,
                Date = DateTime.Parse("2013/08/20")
            },
            new SampleOrder {
                OrderId = 10415,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 4200,
                Date = DateTime.Parse("2013/08/22")
            },
            new SampleOrder {
                OrderId = 10416,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 7175,
                Date = DateTime.Parse("2013/08/14")
            },
            new SampleOrder {
                OrderId = 10417,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 4420,
                Date = DateTime.Parse("2013/08/24")
            },
            new SampleOrder {
                OrderId = 10418,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 5200,
                Date = DateTime.Parse("2013/08/21")
            },
            new SampleOrder {
                OrderId = 10419,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 7920,
                Date = DateTime.Parse("2013/08/17")
            },
            new SampleOrder {
                OrderId = 10420,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 6990,
                Date = DateTime.Parse("2013/08/22")
            },
            new SampleOrder {
                OrderId = 10421,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 2125,
                Date = DateTime.Parse("2013/08/05")
            },
            new SampleOrder {
                OrderId = 10422,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 2220,
                Date = DateTime.Parse("2013/08/16")
            },
            new SampleOrder {
                OrderId = 10423,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 1575,
                Date = DateTime.Parse("2013/08/23")
            },
            new SampleOrder {
                OrderId = 10424,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 1880,
                Date = DateTime.Parse("2013/08/12")
            },
            new SampleOrder {
                OrderId = 10425,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 710,
                Date = DateTime.Parse("2013/08/25")
            },
            new SampleOrder {
                OrderId = 10426,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 390,
                Date = DateTime.Parse("2013/08/20")
            },
            new SampleOrder {
                OrderId = 10427,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 4635,
                Date = DateTime.Parse("2013/08/04")
            },
            new SampleOrder {
                OrderId = 10428,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 4350,
                Date = DateTime.Parse("2013/08/19")
            },
            new SampleOrder {
                OrderId = 10429,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 6020,
                Date = DateTime.Parse("2013/08/02")
            },
            new SampleOrder {
                OrderId = 10430,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 3660,
                Date = DateTime.Parse("2013/08/19")
            },
            new SampleOrder {
                OrderId = 10431,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 4525,
                Date = DateTime.Parse("2013/08/24")
            },
            new SampleOrder {
                OrderId = 10432,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 4410,
                Date = DateTime.Parse("2013/09/12")
            },
            new SampleOrder {
                OrderId = 10433,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 1725,
                Date = DateTime.Parse("2013/09/07")
            },
            new SampleOrder {
                OrderId = 10434,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2715,
                Date = DateTime.Parse("2013/09/14")
            },
            new SampleOrder {
                OrderId = 10435,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 2820,
                Date = DateTime.Parse("2013/09/08")
            },
            new SampleOrder {
                OrderId = 10436,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 2310,
                Date = DateTime.Parse("2013/09/12")
            },
            new SampleOrder {
                OrderId = 10437,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 780,
                Date = DateTime.Parse("2013/09/08")
            },
            new SampleOrder {
                OrderId = 10438,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 2370,
                Date = DateTime.Parse("2013/09/19")
            },
            new SampleOrder {
                OrderId = 10439,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 1410,
                Date = DateTime.Parse("2013/09/09")
            },
            new SampleOrder {
                OrderId = 10440,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 1825,
                Date = DateTime.Parse("2013/09/23")
            },
            new SampleOrder {
                OrderId = 10441,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 4075,
                Date = DateTime.Parse("2013/09/06")
            },
            new SampleOrder {
                OrderId = 10442,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 1020,
                Date = DateTime.Parse("2013/09/04")
            },
            new SampleOrder {
                OrderId = 10443,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 4320,
                Date = DateTime.Parse("2013/09/25")
            },
            new SampleOrder {
                OrderId = 10444,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 7530,
                Date = DateTime.Parse("2013/09/13")
            },
            new SampleOrder {
                OrderId = 10445,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 2820,
                Date = DateTime.Parse("2013/09/08")
            },
            new SampleOrder {
                OrderId = 10446,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 3050,
                Date = DateTime.Parse("2013/09/04")
            },
            new SampleOrder {
                OrderId = 10447,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 5080,
                Date = DateTime.Parse("2013/09/25")
            },
            new SampleOrder {
                OrderId = 10448,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 1125,
                Date = DateTime.Parse("2013/09/13")
            },
            new SampleOrder {
                OrderId = 10449,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 850,
                Date = DateTime.Parse("2013/09/24")
            },
            new SampleOrder {
                OrderId = 10450,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1440,
                Date = DateTime.Parse("2013/09/19")
            },
            new SampleOrder {
                OrderId = 10451,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1950,
                Date = DateTime.Parse("2013/09/02")
            },
            new SampleOrder {
                OrderId = 10452,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 6390,
                Date = DateTime.Parse("2013/10/11")
            },
            new SampleOrder {
                OrderId = 10453,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 4625,
                Date = DateTime.Parse("2013/10/02")
            },
            new SampleOrder {
                OrderId = 10454,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 3510,
                Date = DateTime.Parse("2013/10/24")
            },
            new SampleOrder {
                OrderId = 10455,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 2730,
                Date = DateTime.Parse("2013/10/15")
            },
            new SampleOrder {
                OrderId = 10456,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 2070,
                Date = DateTime.Parse("2013/10/15")
            },
            new SampleOrder {
                OrderId = 10457,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 2320,
                Date = DateTime.Parse("2013/10/18")
            },
            new SampleOrder {
                OrderId = 10458,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 4260,
                Date = DateTime.Parse("2013/10/24")
            },
            new SampleOrder {
                OrderId = 10459,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 840,
                Date = DateTime.Parse("2013/10/18")
            },
            new SampleOrder {
                OrderId = 10460,
                Region = "Europe",
                Country = "United Kingdom",
                City = "London",
                Amount = 7300,
                Date = DateTime.Parse("2013/10/24")
            },
            new SampleOrder {
                OrderId = 10461,
                Region = "Europe",
                Country = "Germany",
                City = "Berlin",
                Amount = 5950,
                Date = DateTime.Parse("2013/10/11")
            },
            new SampleOrder {
                OrderId = 10462,
                Region = "Europe",
                Country = "Spain",
                City = "Madrid",
                Amount = 3220,
                Date = DateTime.Parse("2013/10/25")
            },
            new SampleOrder {
                OrderId = 10463,
                Region = "Europe",
                Country = "Russian Federation",
                City = "Moscow",
                Amount = 3480,
                Date = DateTime.Parse("2013/10/08")
            },
            new SampleOrder {
                OrderId = 10464,
                Region = "Asia",
                Country = "China",
                City = "Beijing",
                Amount = 4830,
                Date = DateTime.Parse("2013/10/26")
            },
            new SampleOrder {
                OrderId = 10465,
                Region = "Asia",
                Country = "Japan",
                City = "Tokyo",
                Amount = 4470,
                Date = DateTime.Parse("2013/10/05")
            },
            new SampleOrder {
                OrderId = 10466,
                Region = "Asia",
                Country = "Republic of Korea",
                City = "Seoul",
                Amount = 3675,
                Date = DateTime.Parse("2013/10/23")
            },
            new SampleOrder {
                OrderId = 10467,
                Region = "Australia",
                Country = "Australia",
                City = "Sydney",
                Amount = 4260,
                Date = DateTime.Parse("2013/10/01")
            },
            new SampleOrder {
                OrderId = 10468,
                Region = "Australia",
                Country = "Australia",
                City = "Melbourne",
                Amount = 4245,
                Date = DateTime.Parse("2013/10/26")
            },
            new SampleOrder {
                OrderId = 10469,
                Region = "Africa",
                Country = "South Africa",
                City = "Pretoria",
                Amount = 1470,
                Date = DateTime.Parse("2013/10/01")
            },
            new SampleOrder {
                OrderId = 10470,
                Region = "Africa",
                Country = "Egypt",
                City = "Cairo",
                Amount = 1810,
                Date = DateTime.Parse("2013/10/02")
            },
            new SampleOrder {
                OrderId = 10471,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 600,
                Date = DateTime.Parse("2013/10/23")
            },
            new SampleOrder {
                OrderId = 10472,
                Region = "North America",
                Country = "United States",
                City = "New York",
                Amount = 7500,
                Date = DateTime.Parse("2013/11/03")
            },
            new SampleOrder {
                OrderId = 10473,
                Region = "North America",
                Country = "United States",
                City = "Los Angeles",
                Amount = 4625,
                Date = DateTime.Parse("2013/11/02")
            },
            new SampleOrder {
                OrderId = 10474,
                Region = "North America",
                Country = "United States",
                City = "Denver",
                Amount = 2625,
                Date = DateTime.Parse("2013/11/09")
            },
            new SampleOrder {
                OrderId = 10475,
                Region = "North America",
                Country = "Canada",
                City = "Vancouver",
                Amount = 1440,
                Date = DateTime.Parse("2013/11/15")
            },
            new SampleOrder {
                OrderId = 10476,
                Region = "North America",
                Country = "Canada",
                City = "Edmonton",
                Amount = 2420,
                Date = DateTime.Parse("2013/11/15")
            },
            new SampleOrder {
                OrderId = 10477,
                Region = "South America",
                Country = "Brazil",
                City = "Rio de Janeiro",
                Amount = 4180,
                Date = DateTime.Parse("2013/11/15")
            },
            new SampleOrder {
                OrderId = 10478,
                Region = "South America",
                Country = "Argentina",
                City = "Buenos Aires",
                Amount = 3720,
                Date = DateTime.Parse("2013/11/25")
            },
            new SampleOrder {
                OrderId = 10479,
                Region = "South America",
                Country = "Paraguay",
                City = "Asuncion",
                Amount = 2730,
                Date = DateTime.Parse("2013/11/08")
            }
        };
    }
}
