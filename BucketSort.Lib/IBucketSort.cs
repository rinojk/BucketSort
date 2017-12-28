using System.Collections.Generic;

namespace BucketSort.Lib
{
    public interface IBucketSort
    {
        List<int> BucketSort(params int[] x);
    }
}