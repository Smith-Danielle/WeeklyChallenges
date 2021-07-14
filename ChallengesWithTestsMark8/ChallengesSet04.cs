using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evens.Add(item);
                }
                else
                {
                    odds.Add(item);
                }
            }

            int sum = evens.Sum(item => item);

            foreach (var item in odds)
            {
                sum -= item;
            }
            return sum;
        }
        

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> lengths = new List<int>();
            lengths.Add(str1.Length);
            lengths.Add(str2.Length);
            lengths.Add(str3.Length);
            lengths.Add(str4.Length);
            int shortest = lengths.Min();
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> smallest = new List<int>();
            smallest.Add(number1);
            smallest.Add(number2);
            smallest.Add(number3);
            smallest.Add(number4);
            int num = smallest.Min();
            return num;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength1 <= 0 || sideLength2 == 0 || sideLength2 <= 0 || sideLength3 == 0 || sideLength3 <= 0)
            {
                return false;
            }
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }
            if (input.All(Char.IsNumber) || input.Contains("-") || input.Contains("."))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countNull = objs.Count(item => item == null);
            var countArray = objs.Length;
            if (countNull > countArray - countNull)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var avgEven2 = numbers.Where(item => item % 2 == 0);
            if (avgEven2.Count() == 0)
            {
                return 0;
            }
            var avgEven = numbers.Where(item => item % 2 == 0).Average();
            
            return avgEven;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int final = 1;

            List<int> answer = new List<int>();
            for (int i = 1; i < number + 1; i++)
            {
                answer.Add(i);
            }
                foreach (var item in answer)
                {
                    final *= item;
                }
                return final;
            

        }
    }
}
