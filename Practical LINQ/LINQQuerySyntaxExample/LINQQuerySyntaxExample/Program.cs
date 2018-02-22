using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuerySyntaxExample
{
    public class Program
    {
        static void Main( string[] args )
        {
            var PeopleList = SetupList();

            Console.WriteLine("Who am I looking For?");
            var name = Console.ReadLine();
            var query = from Person in PeopleList
                        where Person.FirstName.ToLower() == name.ToLower()
                        select Person;

            if ( query.Any() )
            {
                foreach ( var Person in query )
                {
                    Console.WriteLine( Person?.FirstName );
                    Console.WriteLine( Person?.Surname );
                    Console.WriteLine( Person?.Age );
                }
            }
            else
            {
                Console.WriteLine("Can't find the Person");
            }

            PeopleList.Add( new BasicPerson(){ FirstName = "john", Surname = "Jones", Age = 33 }  );

            //this second write should demonstrate deferred execution if the search name was "john"
            //the query isn't redefined but will have a different result using the query result.
            if ( query.Any() )
            {
                foreach ( var Person in query )
                {
                    Console.WriteLine( Person?.FirstName );
                    Console.WriteLine( Person?.Surname );
                    Console.WriteLine( Person?.Age );
                }
            }
            else
            {
                Console.WriteLine("Can't find the Person");
            }

            Console.ReadKey();
        }

        private static List<BasicPerson> SetupList()
        {
            var BasicPeople = new List<BasicPerson>()
            {
                new BasicPerson()
                {
                    FirstName = "James",
                    Surname = "Cardin",
                    Age = 12
                },
                new BasicPerson()
                {
                    FirstName = "Anthony",
                    Surname = "Coleman",
                    Age = 89
                },
                new BasicPerson()
                {
                    FirstName = "John",
                    Surname = "John",
                    Age = 22
                }
            };

            return BasicPeople;
        }
    }

    public class BasicPerson
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
