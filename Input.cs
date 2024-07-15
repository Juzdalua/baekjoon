// using System;

// namespace baekjoon
// {
//     public class Solution
//     {
//         public class InputSystem
//         {
//             int count = int.Parse(Console.ReadLine()!);
//             List<string> inputValues = new List<string>();

//             public List<string> GetInput()
//             {
//                 for (int i = 0; i < count; i++)
//                 {
//                     inputValues.Add(Console.ReadLine()!);
//                 }
//                 return inputValues;
//             }
//         }

//         public static void Main(string[] args)
//         {
//             List<string> input = new List<string>();
//             InputSystem inputSystem = new InputSystem();
//             input = inputSystem.GetInput();

//             for (int i = 0; i < input.Count; i++) Console.WriteLine(input[i]);
//         }
//     }
// }