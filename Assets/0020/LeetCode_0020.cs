using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leetcode._0020
{
    public class LeetCode_0020 : MonoBehaviour
    {
        /*
        给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。
        有效字符串需满足：
        左括号必须用相同类型的右括号闭合。
        左括号必须以正确的顺序闭合。 
        */
        // Start is called before the first frame update
        void Start()
        {
            Solution solution = new Solution();
            string title = "{}";
            Debug.LogError(title + "-" + solution.IsValid(title));
            title = "{}[]()";
            Debug.LogError(title + "-" + solution.IsValid(title));
            title = "{}[]([]))";
            Debug.LogError(title + "-" + solution.IsValid(title));
        }

    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.Count > 0)
                {
                    var last = stack.Peek();
                    if ((last == '{' && chars[i] == '}') ||
                        (last == '[' && chars[i] == ']') || (last == '(' && chars[i] == ')'))
                    {
                        stack.Pop();
                    }
                    else
                        stack.Push(chars[i]);
                }
                else
                {
                    stack.Push(chars[i]);
                }
            }
            return stack.Count == 0;
        }
    }
}