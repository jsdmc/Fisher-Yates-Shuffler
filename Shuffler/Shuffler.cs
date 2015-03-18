using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffler
{
    public class Shuffler
    {
        //inside out implementation of Fisher-Yates shuffle
        public int[] GenerateShuffledArray(int count)
        {
            var inputArray = Enumerable.Range(1, count).ToArray();
            var resultArray = new int[count];

            var rnd = new Random();

            for (var i = 0; i < count; i++)
            {
                var randomIndex = rnd.Next(i);

                resultArray[i] = resultArray[randomIndex];
                resultArray[randomIndex] = inputArray[i];
            }

            return resultArray;
        }
    }
}
