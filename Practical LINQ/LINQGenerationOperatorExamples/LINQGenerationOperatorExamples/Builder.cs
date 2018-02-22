using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGenerationOperatorExamples
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence(int startNumber, int Count) => Enumerable.Range( startNumber, Count );

        public IEnumerable<int> BuildRepeatIntegerSequence(int startNumber, int Count) => Enumerable.Repeat( startNumber, Count );

        public IEnumerable<int> BuildByFive() => Enumerable.Range( 0, 10 ).Select( x => x*5 );

        public IEnumerable<string> BuildAlphabetSequence() => Enumerable.Range( 0, 26 ).Select( x => ((char)('A' + x )).ToString());

        public IEnumerable<string> BuildRandomAlphabetSequence() => Enumerable.Range( 0, 26 ).Select( x => ((char)('A' + new Random().Next(0, 26) )).ToString());
    }
}
