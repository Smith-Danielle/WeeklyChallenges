using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            ChallengesSet03 test = new ChallengesSet03();
            string[] test123 = new string[] { "ab1", "de!" };
            test.ChangeAllElementsToUppercase(test123);
            foreach (var item in test123)
            {
                Console.WriteLine(item);
            }
        }
    }
}
