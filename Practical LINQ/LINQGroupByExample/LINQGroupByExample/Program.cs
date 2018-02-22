using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQGroupByExample
{
    class Program
    {
        static void Main( string[] args )
        {
            BankAccounts theAccounts = new BankAccounts();

            SumAges( theAccounts.m_BankAccounts );
            Console.WriteLine("");
            GetAgesInGroups( theAccounts.m_BankAccounts );

            Console.ReadKey();
        }

        private static void SumAges( List<BankAccount> theAccounts )
        {
            var query = theAccounts.Sum( x => x.Age );

            Console.WriteLine(query);
        }

        private static void GetAgesInGroups( List<BankAccount> theAccounts )
        {
            var query = theAccounts.GroupBy( x => x.Age, x => x.Age, ( groupKey, AgeTotal ) => new
            {
                Key = groupKey,
                TotalAge = AgeTotal.Sum()
            } );

            foreach ( var x in query )
            {
                Console.WriteLine( $"Age of group: {x.Key}, Sum of Ages: {x.TotalAge}" );
            }
        }
    }
}
