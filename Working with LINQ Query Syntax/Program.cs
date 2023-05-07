using System;

using System.Linq;



namespace QueryExercise

{

    class famousPeople

    {

        public string Name { get; set; }

        public int? BirthYear { get; set; } = null;

        public int? DeathYear { get; set; } = null;

    }

    public class Program

    {

        public static void Main(string[] args)

        {

            IList<famousPeople> stemPeople = new List<famousPeople>() {

                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },

                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },

                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },

                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },

                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },

                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },

                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },

                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},

                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},

                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },

                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },

                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },

                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },

                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },

                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },

                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }

     };



            var birthdayQuery2 = from s in stemPeople

                                 where s.BirthYear > 1900

                                 select s;



            Console.WriteLine("Famous people who have a birthdate after 1900:");

            foreach (var person in birthdayQuery2)

                Console.WriteLine($"{person.Name}\nBorn: {person.BirthYear} Died: {person.DeathYear}");

            Console.WriteLine();

            

        }

    }

}
