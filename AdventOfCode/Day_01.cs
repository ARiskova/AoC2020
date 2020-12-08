using AoCHelper;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class Day_01 : BaseDay
    {

        private readonly int[] _input;

        public Day_01()
        {
            _input = File.ReadAllLines(InputFilePath).Select(int.Parse).ToArray();
        }

        public override string Solve_1()
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < _input.Length; i++)
            {
                for (int j = i; j < _input.Length; j++)
                    if (Convert.ToInt16(_input[i]) + Convert.ToInt32(_input[j])== 2020)
                    {
                        a = Convert.ToInt32(_input[i]);
                        b = Convert.ToInt32(_input[j]);
                    }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            return Convert.ToString(a * b);
        }
            
            /*=> $"Solution to {ClassPrefix} {CalculateIndex()}, part 1";*/

        public override string Solve_2()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < _input.Length; i++)
            {
                for (int j = i; j < _input.Length; j++)
                {
                    for (int k = j; k< _input.Length; k++)
                        if (Convert.ToInt16(_input[i]) + Convert.ToInt32(_input[j]) + Convert.ToInt32(_input[k]) == 2020)
                    {
                        a = Convert.ToInt32(_input[i]);
                        b = Convert.ToInt32(_input[j]);
                        c = Convert.ToInt32(_input[k]);
                    }
                }
            }
            return Convert.ToString(a * b * c);
        }
    }
}
