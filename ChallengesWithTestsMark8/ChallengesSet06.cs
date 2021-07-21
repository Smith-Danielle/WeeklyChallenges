using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Any(item => item == null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                List<string> lower = new List<string>();
                foreach (var item in words)
                {
                    lower.Add(item.ToLower());
                }
                if (lower.Contains(word))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                List<string> all = new List<string>();
                foreach (var item in words)
                {
                    all.Add(item);
                }
                if (all.Contains(word))
                {
                    return true;
                }
            }
            return false;  
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var dup = str.GroupBy(item => item).Where(item => item.Count() == 1).Select(item => item.Key).ToList();

            if (dup.Count() == 0)
            {
                return -1;
            }

            return str.IndexOf(dup.Last());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            List<int> max = new List<int>();
            int count = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    max.Add(count);
                    count = 1;
                }
            }
            max.Add(count);
            var answer = max.Max();
            return answer;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null)
            {
                double[] answer2 = new double[0];
                return answer2;
            }
            List<double> nth = new List<double>();
            int count = n - 1;
            for (int i = 0; i < elements.Count; i++)
            {
                if (i == count)
                {
                    nth.Add(elements[i]);
                    count += n;
                }

            }
            var answer = nth.ToArray();
            return answer;
        }
    }
}
