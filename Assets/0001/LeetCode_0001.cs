using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leetcode._0001
{
    public class LeetCode_0001 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Solution solution = new Solution();
            int[] num = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            Debug.LogError(num[0] + "--" + num[1]);
        }

    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}