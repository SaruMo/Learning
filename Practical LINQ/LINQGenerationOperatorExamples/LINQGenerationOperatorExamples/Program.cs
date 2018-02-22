using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGenerationOperatorExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            Builder m_Builder = new Builder();

            foreach ( var integer in m_Builder.BuildIntegerSequence( 1, 10 ) )
            {
                Console.WriteLine(integer);
            }

            foreach ( var integer in m_Builder.BuildRepeatIntegerSequence( 1, 10 ) )
            {
                Console.WriteLine(integer);
            }

            foreach ( var integer in m_Builder.BuildByFive() )
            {
                Console.WriteLine(integer);
            }

            foreach ( var character in m_Builder.BuildAlphabetSequence() )
            {
                Console.WriteLine(character);
            }

            foreach ( var character in m_Builder.BuildRandomAlphabetSequence() )
            {
                Console.WriteLine(character);
            }

            Console.ReadKey();
        }
    }
}
