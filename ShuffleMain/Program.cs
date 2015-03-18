using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var item in new Shuffler().GenerateShuffledArray(100))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
