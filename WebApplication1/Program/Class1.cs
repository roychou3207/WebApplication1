using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Program
{
    public class Class1
    {
        static int[] Question1(int[] nums, int target)
        {
            int[] array = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                var v = nums[i];

                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        array = new int[] { i, j };
                    }
                }

            }
            return array;
        }



        static void Question4(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }


        static bool Question5(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("y");
                return true;
            }
            if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("y");
                return true;
            }
            else
            {
                Console.WriteLine("n");
                return false;
            }
        }
    }
}