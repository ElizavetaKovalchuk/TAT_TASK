using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    /// <summary>
    /// This class contains methods for working with the sequence
    /// </summary>
    class SequenceOfSymbol 
    {
        public string sequenceOfSymbol;
        public SequenceOfSymbol(string acceptedSequence)
        {
            sequenceOfSymbol = acceptedSequence;
        }
        /// <summary>
        /// This method finds the maximum number of identical consecutive symbols in a string
        /// </summary>
        /// <returns>The maximum number of identical consecutive symbols in a string</returns>
        public int SerchMaxNumberOfSymbol(){
            char[] sequence = sequenceOfSymbol.ToCharArray();
            int max_count = 0;
            int count = 1;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    count++;
                }
                else if (count > max_count)
                {
                    max_count = count;
                    count = 1;
                }
                else
                {
                    count = 1;
                }
            }
            return max_count;
        }
    }
}
