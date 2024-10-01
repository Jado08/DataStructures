using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Backtracking
    {
        private static void GeneratePermutations(int[] num, List<int> curr, bool[] used, List<List<int>> permutations)
        {
            if (curr.Count == num.Length)
            {
                permutations.Add(new List<int>(curr));
                return;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    curr.Add(num[i]);

                    GeneratePermutations(num,curr,used,permutations);

                    curr.RemoveAt(curr.Count - 1);
                    used[i] = false;
                }
            }
        }
        public static void AllPermutations()
        {
            int[] num = { 2, 4, 6 };
            List<List<int>> permutations = new List<List<int>>();

            GeneratePermutations(num, new List<int>(), new bool[num.Length], permutations);

            Console.WriteLine("All Permutations : ");
            foreach(var permutation in permutations)
            {
                Console.Write("{ ");
                foreach (var nm in permutation)
                {
                    Console.Write(nm + " ");
                }
                Console.WriteLine("}");
            }
        }
    }
}
