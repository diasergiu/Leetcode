using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_code_review
{
    //https://leetcode.com/problems/permutations-ii/
    // just ineficient fasteer then 5%.
    class Permutation2
    {
            IList<IList<int>> permutations;

            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                permutations = new List<IList<int>>();
                FindPermutations(nums, new bool[nums.Length], new List<int>());
                return permutations;

            }

            private void FindPermutations(int[] nums, bool[] isUsed, List<int> soFar)
            {
                if (soFar.Count == nums.Length)
                {
                    if (!permutations.Any(x => x.SequenceEqual(soFar)))
                    {
                        permutations.Add(soFar.ToList());
                    }
                    return;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (!isUsed[i])
                    {
                        soFar.Add(nums[i]);
                        isUsed[i] = true;
                        FindPermutations(nums, isUsed, soFar);
                        soFar.RemoveAt(soFar.Count - 1);
                        isUsed[i] = false;
                    }
                }

            }
            private void print(List<int> printList)
            {

                foreach (int i in printList)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
}
