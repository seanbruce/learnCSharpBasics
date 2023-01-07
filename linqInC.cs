using System;
namespace learnCSharpBasics
{
    class City
    {
        public string Name { get; set; } = "unknown";
        public long Population { get; set; }
        public override string ToString()
        {
            return $"City - {Name}, Population - {Population}";
        }
    }

    class State
    {
        public string Name { get; set; } = "unknown";
        public List<City> Cities { get; } = new List<City>();
    }

    public class linqInC
    {
        public static void run()
        {
            // query data source
            int[] scores = { 2, 4, 13, 8, 7, 15, 9, 2 };

            // query variable and query expression
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 7
                orderby score descending
                select score;

            // execute the query
            foreach (int score in highScoresQuery)
            {
                Console.WriteLine(score);
            }

            // another way of excuting the query
            int highScoreCount = highScoresQuery.Count();
            Console.WriteLine(highScoreCount);

            List<City> cities = new List<City> {
                new City { Population = 300000 },
                new City { Population = 1000000},
                new City { Population = 500000 },
                new City { Population = 600000 },
            };

            // compose query using method call
            IEnumerable<City> queryMajorCities = cities.Where(c => c.Population > 500000);

            // implicit inferred query type
            var smallCitiesQuery =
                from city in cities
                where city.Population <= 500000
                orderby city.Population descending
                select city;

            List<State> states = new List<State>
            {
                new State
                {
                    Name = "Alabama",
                    Cities =
                    {
                        new City
                        {
                            Name = "Huntsville",
                            Population = 100000
                        },
                        new City
                        {
                            Name = "Birmingham",
                            Population = 200000
                        },
                        new City
                        {
                            Name = "Mobile",
                            Population = 300000
                        }
                    }
                },
                new State
                {
                    Name = "Georgia",
                    Cities =
                    {
                        new City
                        {
                            Name = "Atlanta",
                            Population = 100000,
                        },
                        new City
                        {
                            Name = "Roswell",
                            Population = 200000,
                        },
                        new City
                        {
                            Name = "Fulton",
                            Population = 300000,
                        }
                    }
                }
            };

            var majorCities =
                from state in states
                from city in state.Cities
                where city.Population >= 200000
                orderby city.Population descending
                select city;

            foreach(City city in majorCities)
            {
                Console.WriteLine(city);
            }

            var cityGroupByName =
                from state in states
                from city in state.Cities
                group city by city.Name[0];

            foreach(var group in cityGroupByName)
            {
                Console.WriteLine(group.Key);
                foreach(var city in group)
                {
                    Console.Write(city);
                }
                Console.WriteLine();
            }

            var majorCitiesName =
                from state in states
                from city in state.Cities
                where city.Population >= 200000
                orderby city.Population descending
                select new
                {
                    city.Name
                };

            foreach(var cityWithJustName in majorCitiesName)
            {
                Console.WriteLine(cityWithJustName.Name);
            }
        }
    }
}

