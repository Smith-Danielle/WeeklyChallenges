using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            List<bool> listed = new List<bool>();
            foreach (var item in vals)
            {
                listed.Add(item);
            }
            return listed.Contains(false);

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool answer = true;
            List<int> odds = new List<int>();
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    odds.Add(item);
                }
            }
            foreach (var item in odds)
            {
                sum += item;
            }

            if (sum % 2 == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool answer = true;
            bool upper = password.Any(char.IsUpper);
            bool lower = password.Any(char.IsLower);
            bool number = password.Any(char.IsDigit);
            if (upper == true && lower == true && number == true)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            decimal answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums.First();
            var last = nums.Last();
            var answer = last - first;
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            var answer = odds.ToArray();
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
           
            
        }
    }
}
