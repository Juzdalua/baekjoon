using System;
using System.Linq;

namespace baekjoon
{
    public class Solution_2720
    {
        public class InputSystem
        {
            int count = int.Parse(Console.ReadLine()!);
            List<string> inputValues = new List<string>();

            public List<string> GetInput()
            {
                for (int i = 0; i < count; i++)
                {
                    inputValues.Add(Console.ReadLine()!);
                }
                return inputValues;
            }
        }

        public void Answer()
        {
            List<string> input = new List<string>();
            InputSystem inputSystem = new InputSystem();
            input = inputSystem.GetInput();

            int quater = 25;
            int dime = 10;
            int nickel = 5;
            int penny = 1;

            int[] money = new int[] { quater, dime, nickel, penny };

            List<string> answer = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> answerStr = new List<string>();
                int current = int.Parse(input[i]);

                for (int j = 0; j < money.Length; j++)
                {
                    if (current == 0)
                    {
                        answerStr.Add("0");
                        continue;
                    }
                    answerStr.Add((current / money[j]).ToString());
                    current %= money[j];
                }

                answer.Add(String.Join(" ", answerStr));
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}