using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort.Lib
{
    public class BucketSortMain : IBucketSort
    {
        public BucketSortMain()
        {
            Sorts = new OtherSorts();
        }

        public OtherSorts Sorts { get; }

        public List<int> Sort(params int[] x)
        {
            if (x == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return BucketSort(x);
            }
        }

        public List<int> BucketSort(params int[] x)
        {
            List<int> result = new List<int>();

            int numOfBuckets = 10;

            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>();

            for (int i = 0; i < x.Length; i++)
            {
                int buckitChoice = (x[i] / numOfBuckets);
                buckets[buckitChoice].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                int[] temp = Sorts.BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }
    }
}
