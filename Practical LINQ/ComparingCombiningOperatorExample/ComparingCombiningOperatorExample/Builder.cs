using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingCombiningOperatorExample
{
    public class Builder
    {
        public IEnumerable<int> CompareSequencesIntersect()
        {
            var Seq1 = Enumerable.Range( 1, 10 );
            var seq2 = Enumerable.Range( 1, 10 )
                                 .Select( x => x * x );
            //the values that are the same                  
            return Seq1.Intersect( seq2 );
        }

        public IEnumerable<int> CompareSequencesExcept()
        {
            var Seq1 = Enumerable.Range( 1, 10 );
            var seq2 = Enumerable.Range( 1, 10 )
                                 .Select( x => x * x );
            //the values that are in seq1 and not seq2                 
            return Seq1.Except( seq2 );
        }

        public IEnumerable<int> ConcatSequences()
        {
            var Seq1 = Enumerable.Range( 1, 10 );
            var seq2 = Enumerable.Range( 1, 10 )
                                 .Select( x => x * x );
            //concat the sequences indifferently     
            return Seq1.Concat( seq2 );
        }

        public IEnumerable<int> DistinctSequences()
        {
            var Seq1 = Enumerable.Range( 1, 10 );
            var seq2 = Enumerable.Range( 1, 10 )
                                 .Select( x => x * x );
            //concat the sequences with distinct values                
            return Seq1.Concat( seq2 ).Distinct();
        }

        public IEnumerable<int> UnionSequences()
        {
            var Seq1 = Enumerable.Range( 1, 10 );
            var seq2 = Enumerable.Range( 1, 10 )
                                 .Select( x => x * x );
            //another way to get distinct values                
            return Seq1.Union( seq2 );
        }
    }
}
