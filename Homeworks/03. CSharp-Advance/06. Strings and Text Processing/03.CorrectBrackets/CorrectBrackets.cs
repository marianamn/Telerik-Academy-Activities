namespace _03.CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CorrectBrackets
    {
        public static void Main()
        {
            string expression = Console.ReadLine();

            int countOpen = 0;
            int countClosed = 0;
            int positionOpen = 0;
            int positionClosed = 0;
            bool isCorrect = true;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    countOpen++;
                }

                if (expression[i] == ')')
                {
                    countClosed++;
                }
            }

            positionOpen = expression.IndexOf('(');
            positionClosed = expression.IndexOf(')');

            if (positionOpen > positionClosed)
            {
                isCorrect = false;
            }

            if (isCorrect && countClosed == countOpen)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorect");
            }

        }
    }
}
