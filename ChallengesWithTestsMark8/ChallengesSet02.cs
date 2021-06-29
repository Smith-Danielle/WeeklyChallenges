using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool answer = Char.IsLetter(c);
            return answer; 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int units = vals.Length;
            bool even = false;
            if (units % 2 == 0)
            {
                even = true;
            }
            return even;
        }

        public bool IsNumberEven(int number)
        {
            bool evenCount = false;
            if (number % 2 == 0)
            {
                evenCount = true;
            }
            return evenCount;
        }

        public bool IsNumberOdd(int num)
        {
            bool oddCount = false;
            if (num % 2 != 0)
            {
                oddCount = true;
            }
            return oddCount;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            int count = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var items in numbers)
            {
                count++;
            }
            if (count == 0)
            {
                return 0;
            }

            List<double> numbers2 = new List<double>();

            foreach (var item in numbers)
            {
                numbers2.Add(item);
            }
            numbers2.Sort();
            double maxNum = numbers2[0];
            double minNum = numbers2[numbers2.Count - 1];
            return maxNum + minNum;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int count1 = str1.Length;
            int count2 = str2.Length;
            if (count1 < count2)
            {
                return count1;
            }
            else
            {
                return count2;
            }
        }

        public int Sum(int[] numbers)
        {
            int aSum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var item in numbers)
            {
                aSum += item;
            }
            return aSum;
        }

        public int SumEvens(int[] numbers)
        {
            int sumEvens = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var items in numbers)
            {
                if (items % 2 == 0)
                {
                    sumEvens += items;
                }
            }
            return sumEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sumAll = 0;
            bool answer = false;
            if (numbers == null)
            {
                return answer;
            }
            foreach (var item in numbers)
            {
                sumAll += item;
            }
            if (sumAll % 2 != 0)
            {
                answer = true;
            }
            return answer;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddCount = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }
    }
}
