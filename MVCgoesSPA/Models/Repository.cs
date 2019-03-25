using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVCgoesSPA.Models
{
    public class Repository
    {
        private static List<Spa> _spaList = new List<Spa>();
        private static readonly string[] spaNameAdjectives = {
            "Red", "Blue", "Icy", "Sporty", "Mega", "Ladies'",
            "Gentlemen's", "Finnish", "Free"
        };
        private static readonly string[] spaNamePrefixes = {
            "King of", "Ultima", "Dream", "XXL", "Über",
            "Cool", "Super-swim", "Generic", "Old fashioned",
            ""
        };
        private static readonly string[] spaNameSuffixes = {
            "Spa", "Bathing Place", "Pool Corporation", "Water Tanks",
            "Suite & Bath", "Sauna and Pools", "Bath"
        };
        private static readonly string[] firstNames = {
            "David", "Dean", "Sean", "James", "John", "Kim",
            "Alice", "Wayne", "George", "Ernst", "William",
            "Isac", "Tony", "Huy", "Dan", "Claire", "Jesse",
            "Laura", "Rory", "Katya", "Adam", "Eva", "Cecilia",
            "Freddy", "Norah", "Tim", "Holly", "Sam", "Gia",
            "Olga", "Bob", "Bill", "Donna", "Arnold", "Gwen",
            "Leo", "Rob", "Darude", "Louis"
        };
        private static readonly string[] lastNames = {
            "Doe", "Johnsson", "McMacinson", "Hudson",
            "Forrester", "Wood", "Davidson", "Quantum",
            "Hudson", "Whitaker", "Kelly", "Duck",
            "Swan", "Bell", "Diesel", "Ford", "Hill",
            "Washington", "Utah", "Raptor", "Woo",
            "Jin", "Robertson", "Tuckson", "Maybe",
            "Yes", "Warren", "Visitor", "Noname",
            "Stone", "Smoke", "Cloud", "Sun", "Lake",
            "River", "Bridgestone", "Hammer", "Jofa"
        };

        static Repository()
        {
            var rnd = new Random();

            // generate random number of spas
            for (var i = 0; i < new Random().Next(20, 100); i++)
            {
                _spaList.Add(new Spa
                {
                    Name = $"{spaNameAdjectives[rnd.Next(spaNameAdjectives.Length)]} {spaNamePrefixes[rnd.Next(spaNamePrefixes.Length)]} {spaNameSuffixes[rnd.Next(spaNameSuffixes.Length)]}",
                    Visitors = new List<Visitor>(),
                    DayTicketPrice = (decimal)rnd.NextDouble() * 25,
                    WeekEndTicketPrice = (decimal)rnd.NextDouble() * 100,
                });
            }

            var visitorList = new List<Visitor>();
            visitorList.Add(new Visitor
            {
                FirstName = "Diffie",
                LastName = "Hellman",
                Email = "rijdnael@gmail.com"
            });
            visitorList.Add(new Visitor
            {
                FirstName = "Jack",
                LastName = "Bauer",
                Phone = "1235767",
                Email = "24hours@hotmail.com"
            });

            for (var i = 0; i < rnd.Next(1000, 2000); i++)
            {
                var firstName = firstNames[rnd.Next(firstNames.Length)];
                var lastName = lastNames[rnd.Next(lastNames.Length)];
                visitorList.Add(new Visitor
                {
                    FirstName = firstName,
                    LastName = lastName,
                    FeedbackRate = rnd.Next(0, 5) < 2 ? (int?) null : rnd.Next(1, 5),
                    Email = $"{firstName}.{lastName}@my-email.org",
                    Phone = rnd.Next(999999, 999999999).ToString(),
                    VisitTime = DateTime.UtcNow.AddDays(-rnd.Next(3000)).AddHours(-rnd.Next(3000)).AddMinutes(rnd.Next(3000) - 1500)
                });
            }

            foreach (var visitor in visitorList)
            {
                _spaList[rnd.Next(_spaList.Count)].Visitors.Add(visitor);
            }
        }

        public IEnumerable<Spa> GetAllSpas()
        {
            Thread.Sleep(_spaList.Count * 50);
            return _spaList;
        }
    }
}