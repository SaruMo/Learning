using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingCombiningOperatorExample
{
    class Program
    {
        static void Main( string[] args )
        {
            Builder m_Builder = new Builder();
            Console.WriteLine("Intersect:");
            foreach ( var integer in m_Builder.CompareSequencesIntersect() )
            {
                Console.WriteLine(integer);
            }

            Console.WriteLine("Except:");
            foreach ( var integer in m_Builder.CompareSequencesExcept() )
            {
                Console.WriteLine(integer);
            }

            Console.WriteLine("Concat:");
            foreach ( var integer in m_Builder.ConcatSequences() )
            {
                Console.WriteLine(integer);
            }

            Console.WriteLine("Distinct:");
            foreach ( var integer in m_Builder.DistinctSequences() )
            {
                Console.WriteLine(integer);
            }

            Console.WriteLine("Union:");
            foreach ( var integer in m_Builder.UnionSequences() )
            {
                Console.WriteLine(integer);
            }

            Console.ReadKey();
        }
    }
}
