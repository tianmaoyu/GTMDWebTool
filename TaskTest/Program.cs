using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        { // Wait on a single task with a timeout specified.
            Console.ReadKey();
            var nums = Enumerable.Range(0, 100000).ToArray();

            // Create a load-balancing partitioner. Or specify false for static partitioning.
            Partitioner<int> customPartitioner = Partitioner.Create(nums, false);

            // The partitioner is the query's data source.
            var q = from x in customPartitioner.AsParallel()
                    select x * Math.PI;

            q.ForAll((x) =>
            {
                Console.WriteLine(x);
            });
            foreach (var n in nums)
            {
                Console.WriteLine(n * Math.PI);
            }
            Console.ReadKey();
        }
    

       
    }
}
