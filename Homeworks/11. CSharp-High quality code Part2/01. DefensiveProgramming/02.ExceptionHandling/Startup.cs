using System;
using System.Collections.Generic;
using _02.ExceptionHandling.Exams;

namespace _02.ExceptionHandling
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(ExtractSequence.Subsequence("Hello!".ToCharArray(), 2, 3));
            Console.WriteLine(ExtractSequence.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2));
            Console.WriteLine(ExtractSequence.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4));
            Console.WriteLine(ExtractSequence.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0));

            Console.WriteLine(ExtractSequence.ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractSequence.ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractSequence.ExtractEnding("beer", 4));
            Console.WriteLine(ExtractSequence.ExtractEnding("Hi", 100));

            var firstNumber = 23;
            try
            {
                CheckPrime(firstNumber);
                Console.WriteLine("{0} is prime.", firstNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} is not prime.", firstNumber);
                Console.WriteLine("ErrorMessage: {0}", ex.Message);
            }

            var secondNumber = 33;
            try
            {
                CheckPrime(secondNumber);
                Console.WriteLine("{0} is prime.", secondNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} is not prime.", secondNumber);
                Console.WriteLine("ErrorMessage: {0}", ex.Message);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }

        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new Exception("The number is not prime!");
                }
            }
        }
    }
}
