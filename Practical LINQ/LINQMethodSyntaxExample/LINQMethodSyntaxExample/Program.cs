using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethodSyntaxExample
{
    class Program
    {
        static void Main( string[] args )
        {
            List<Person> People = new List<Person>()
            {
                new Person() { FirstName = "James", Surname = "Clarke", Age = 5 },
                new Person() { FirstName = "Jack", Surname = "Walsh", Age = 10 },
                new Person() { FirstName = "Geoff", Surname = "Ingle", Age = 15 }
            };

            Console.WriteLine("Find Person:");
            var SearchName = Console.ReadLine();

            //deferred execution
            IEnumerable<Person> Result = FindPerson( People, SearchName );

            //example of first() using lambda.
            //Console.WriteLine(People.First( x => x.FirstName.ToLower() == SearchName.ToLower() ).FirstName);

            foreach ( var person in Result )
            {
                Console.WriteLine($"{person.FirstName} {person.Surname}");
            }

            People.Add( new Person(){ FirstName = "James", Surname = "Cardin", Age = 20 }  );

            foreach ( var person in Result )
            {
                Console.WriteLine($"{person.FirstName} {person.Surname}");
            }

            if ( !Result.Any() )
            {
                Console.WriteLine($"No Such Person");
            }

            Console.ReadKey();
        }

        private static IEnumerable<Person> FindPerson( List<Person> thePeople, string theSearchName )
        {
            return thePeople.Where( x => x.FirstName.ToLower() == theSearchName.ToLower() ).Select( x => x );
        }
    }
}
