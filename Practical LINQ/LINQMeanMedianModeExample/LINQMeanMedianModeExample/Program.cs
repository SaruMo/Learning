using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQGroupByExample;

namespace LINQMeanMedianModeExample
{
    class Program
    {
        static void Main( string[] args )
        {
            BankAccounts theAccounts = new BankAccounts();

            CalculateMean( theAccounts.m_BankAccounts );
            Console.WriteLine();
            CalculateMedian( theAccounts.m_BankAccounts );
            Console.WriteLine();
            CalculateMode( theAccounts.m_BankAccounts );
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void CalculateMean( List<BankAccount> theAccounts )
        {
            Console.WriteLine(theAccounts.Average( x => x.Age  ));
        }

        private static void CalculateMedian( List<BankAccount> theAccounts )
        {
            theAccounts.OrderBy( x => x.Age );
            int MiddlePos = theAccounts.Count / 2;
            decimal median;

            if ( theAccounts.Count % 2 == 0 )
            {
                median = ( theAccounts[ MiddlePos - 1 ].Age + theAccounts[ MiddlePos + 1 ].Age ) / 2;
            }
            else
            {
                median = theAccounts[ MiddlePos ].Age;
            }
            Console.WriteLine(median);
        }

        private static void CalculateMode( List<BankAccount> theAccounts )
        {
            var query = theAccounts.GroupBy( x => x.Age ).OrderBy( x => x.Count() );
            Console.WriteLine(query.LastOrDefault().Key);
        }
    }
}
