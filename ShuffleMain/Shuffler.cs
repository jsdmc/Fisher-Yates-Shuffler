using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleMain
{
    public class Shuffler
    {
        public int[] GenerateShuffledArray(int count)
        {
            var inputArray = Enumerable.Range(1, count).ToArray();
            var resultArray = new int[count];

            for (var i = 0; i < count; i++)
            {
                var randomIndex = new Random().Next(i);

                resultArray[i] = resultArray[randomIndex];
                resultArray[randomIndex] = inputArray[i];
            }

            return resultArray;
        }
    }
}
