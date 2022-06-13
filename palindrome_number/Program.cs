using System;

namespace palindrome_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(121));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string xString = x.ToString();
            char[] xStringArray = xString.ToCharArray();
            Array.Reverse(xStringArray);
            if (xString == new string(xStringArray))
            {
                return true;
            }
            return false;
        }
    }
}