using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shuffler;

namespace Shuffler.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shuffler = new Shuffler();
            var numberOfElements = 10000;

            foreach (var item in shuffler.GenerateShuffledArray(numberOfElements))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
