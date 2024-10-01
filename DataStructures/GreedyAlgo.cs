using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class GreedyAlgo
    {
        public static List<int> PaperLeafCount(int[] paperLeaf, int pcs)
        {
            List<int> result = new List<int>();

            foreach(var leaf in paperLeaf)
            {
                while(pcs >= leaf)
                {
                    pcs -= leaf;
                    result.Add(leaf);
                }
            }
            return result;
        }
        public static void PracticeGreedyAlgo()
        {
             int[] paperLeaf = { 2, 3, 1, 5 };
             int pcs = 15;

             List<int> totalLeaf = PaperLeafCount(paperLeaf, pcs);

             Console.Write($"The total of paper leaf to make {pcs} is {totalLeaf.Count}");
             Console.WriteLine("\nPaper Leaf used :");
             foreach(var leaf in totalLeaf)
             {
                 Console.WriteLine($"{leaf} pc");
             }
        }
    }

    
}
