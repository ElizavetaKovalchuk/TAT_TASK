using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        /// <summary>
        /// Prints to the console the maximum number of identical consecutive symbols in the string
        /// </summary>
        /// <param name="args">Сommand-line arguments</param>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a numeric argument.");
            }
            else
            {
                SequenceOfSymbol acceptedSequence = new SequenceOfSymbol(args[0]);
                Console.WriteLine(acceptedSequence.SerchMaxNumberOfSymbol());
            }
           
            Console.ReadKey();
        }
    }
}
