using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_code_review
{
    //https://leetcode.com/problems/3sum/
    // medium
    public class _3Sum
    {
        private List<IList<int>> listReturn;

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            listReturn = new List<IList<int>>();
            Dictionary<int, int> memoryNumbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!memoryNumbers.ContainsKey(nums[i]))
                    memoryNumbers.Add(nums[i], 1);
                else
                {
                    memoryNumbers[nums[i]]++;
                }
            }

            int sum = 0;
            List<int> listToPut = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum += nums[i];
                memoryNumbers[nums[i]]--;
                listToPut.Add(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    memoryNumbers[nums[j]]--;
                    listToPut.Add(nums[j]);
                    if (memoryNumbers.ContainsKey(sum * -1) && memoryNumbers[sum * -1] > 0)
                    {
                        listToPut.Add(sum * -1);
                        listToPut.Sort();
                        if (!listReturn.Any(x => x.SequenceEqual(listToPut)))
                        {
                            listReturn.Add(listToPut.ToList());
                        }
                        listToPut.RemoveAt(listToPut.Count - 1);

                    }
                    sum -= nums[j];
                    memoryNumbers[nums[j]]++;
                    listToPut.RemoveAt(listToPut.Count - 1);
                }

                sum -= nums[i];
                memoryNumbers[nums[i]]++;
                listToPut.RemoveAt(listToPut.Count - 1);
            }

            return listReturn;
        }
    }
}
