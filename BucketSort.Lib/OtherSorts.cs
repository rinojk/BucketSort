using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort.Lib
{
    public class OtherSorts
    {
        public int[] BubbleSortList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input.ToArray();
        }
    }
}
