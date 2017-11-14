using System;
using System.Text;
using NCalc;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] operands = new char[] { '*', '+', '-', '/' };
            GenerateMathProblem(4,3,operands);
        }

        public static void GenerateMathProblem(int numOfOperands, int difficulty, char[] operands)
        {
            Random r = new Random();

            StringBuilder problem = new StringBuilder();
            int randomNumber;
            for (int i = 0; i < numOfOperands-1; i++)
            {
                randomNumber = getRandomNumber(difficulty, r);
                problem.Append(randomNumber);

                char randomOperand = operands[r.Next(0, 4)];
                problem.Append(randomOperand);
            }
            problem.Append(getRandomNumber(difficulty, r));
            Console.WriteLine("Problem to solve: " + problem);
            Expression e = new Expression(problem.ToString());
            Console.WriteLine("Solution: " + Math.Round(decimal.Parse(e.Evaluate().ToString()),2));
            Console.Read();
        }

        public static int getRandomNumber(int difficulty, Random r)
        {
            
            return r.Next(1, (difficulty * 10));
        }
    }
}