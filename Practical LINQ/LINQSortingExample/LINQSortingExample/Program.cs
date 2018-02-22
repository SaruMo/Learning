using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSortingExample
{
    class Program
    {
        static void Main( string[] args )
        {
            List<Person> People = new List<Person>()
            {
                new Person() { FirstName = "James", Surname = "Clarke", Age = 5 },
                new Person() { FirstName = "Jack", Surname = "Walsh", Age = 10 },
                new Person() { FirstName = "Geoff", Surname = "Ingle", Age = 15 },
                new Person() { FirstName = "Aaron", Surname = "Clarke", Age = 20 },
                new Person() { FirstName = "Lee", Surname = "Speed", Age = 25 },
                new Person() { FirstName = "Jason", Surname = "Malcolm", Age = 30 }
            };

            Console.WriteLine( "Origingal order:\n" );
            People.ForEach( x => Console.WriteLine( x.ToString() ) );

            OrderBy( People );
            OrderByDescending( People );
            OrderByReverse( People );
            OrderByThenBy( People );

            Console.ReadKey();
        }

        private static void OrderBy( List<Person> thePeople )
        {
            Console.WriteLine( "" );
            Console.WriteLine( "OrderBy Surname:\n" );
            var theOrderBy = thePeople.OrderBy( x => x.Surname );
            foreach ( var person in theOrderBy )
            {
                Console.WriteLine( person.ToString() );
            }

            Console.WriteLine( "" );
            Console.WriteLine( "OrderBy age:\n" );
            theOrderBy = thePeople.OrderBy( x => x.Age );
            foreach ( var person in theOrderBy )
            {
                Console.WriteLine( person.Age.ToString() );
            }
        }

        private static void OrderByDescending( List<Person> thePeople )
        {
            Console.WriteLine( "" );
            Console.WriteLine( "OrderByDescending Surname:\n" );
            var theOrderBy = thePeople.OrderByDescending( x => x.Surname );
            foreach ( var person in theOrderBy )
            {
                Console.WriteLine( person.ToString() );
            }
        }

        private static void OrderByReverse( List<Person> thePeople )
        {
            Console.WriteLine( "" );
            Console.WriteLine( "OrderBy Reverse Surname:\n" );
            var theOrderBy = thePeople.OrderBy( x => x.Surname ).Reverse();
            foreach ( var person in theOrderBy )
            {
                Console.WriteLine( person.ToString() );
            }
        }

        private static void OrderByThenBy( List<Person> thePeople )
        {
            Console.WriteLine( "" );
            Console.WriteLine( "OrderBy Surname thenBy Firestname:\n" );
            var theOrderBy = thePeople.OrderBy( x => x.Surname ).ThenBy( x => x.FirstName );
            foreach ( var person in theOrderBy )
            {
                Console.WriteLine( person.ToString() );
            }
        }
    }
}
