using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leetcode._0014
{

    /*
    编写一个函数来查找字符串数组中的最长公共前缀。
    如果不存在公共前缀，返回空字符串 ""。

    示例 1：
    输入：strs = ["flower","flow","flight"]
    输出："fl"

    示例 2：
    输入：strs = ["dog","racecar","car"]
    输出：""
    解释：输入不存在公共前缀。
     
    提示：
    0 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] 仅由小写英文字母组成
    */

    public class LeetCode_0014 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Solution solution = new Solution();
            string[] strs = new string[] { "ABC", "ABC" };
            // Debug.LogError(solution.LongestCommonPrefix(strs));

            // strs = new string[] { "TTTAAA", "TTTAAAA", "TTTAA" };
            // Debug.LogError(solution.LongestCommonPrefix(strs));

            // strs = new string[] { "TTTAAA" };
            // Debug.LogError(solution.LongestCommonPrefix(strs));

            strs = new string[] { "flower", "flower", "flower", "flower" };
            Debug.LogError(solution.LongestCommonPrefix(strs));


            strs = new string[] { "flower", "flow", "flight" };
            Debug.LogError(solution.LongestCommonPrefix(strs));

            strs = new string[] { "ab", "a" };
            Debug.LogError(solution.LongestCommonPrefix(strs));
        }

    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";


            //挑选第一个作为标尺

            for (int i = 0; i < strs[0].Length; ++i)
            {
                char c = strs[0][i];//拿到每一个字符
                for (int j = 1; j < strs.Length; ++j)//去和剩下的作比较
                {
                    //如果有一致的情况  始终不满足i == strs[j].Length 
                    if (i == strs[j].Length || strs[j][i] != c)//如果长度不一致/字符不相等
                    {
                        return strs[0].Substring(0, i);
                    }

                }
            }

            return strs[0];


        }
    }
}