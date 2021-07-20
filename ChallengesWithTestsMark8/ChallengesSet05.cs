using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            int answer = 0;
            int count = 2;
            if (startNumber < n)
            {
                return n;
            }
            else
            {
                while (answer < startNumber)
                {
                    answer = n * count;
                    count++;
                }
            }
            if (answer == startNumber)
            {
                answer += n;
            }
            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int followers = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    followers += numbers[i + 1];
                }
            }
            return followers;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }
            if (words.Length == 0)
            {
                return "";
            }
            
            var together = string.Join(" ", words);
            var answer = Regex.Replace(together, " {2,}", " ").Trim();
            if (answer.Length == 0)
            {
                return "";
            }
            answer += ".";
            return answer;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                double[] answer2 = new double[0];
                return answer2;
            }
            List<double> fourth = new List<double>();
            int count = 3;
            for (int i = 0; i < elements.Count; i++)
            {
                if (i == count)
                {
                    fourth.Add(elements[i]);
                    count += 4;
                }

            }
            var answer = fourth.ToArray();
            return answer;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
