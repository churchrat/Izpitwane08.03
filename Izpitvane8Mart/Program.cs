using System.Collections.Immutable;

namespace Izpitvane8Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine(Math.Round(Average(nums), 2));
            Console.WriteLine($"Броят на нулите в масива е {ZeroCount(nums)}");
            Console.WriteLine(nums[ClosestToAverage(nums, Average(nums))]);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }
        static int ClosestToAverage(int[] nums, double average)
        {
            double diff = 0;
            double minDiff = double.MaxValue;
            int closest =  0;
            for (int i = 0; i < nums.Length; i++)
            {
                diff = Math.Abs(average - nums[i]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closest = i;
                }
            }
            return closest;
        }
        static int ZeroCount(int[] nums)
        {
            int zeroBr = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroBr += 1;
                }
            }
            return zeroBr;
        }
        static double Average(int[] nums)
        {
            double sumAverage = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumAverage += nums[i];
            }
            return sumAverage / nums.Length;
        }
    }
}
