using System;
using System.Collections.Generic;

namespace TreeDepthCalculator
{
    class Branch
    {
        public List<Branch> branches { get; set; }

        public Branch()
        {
            branches = new List<Branch>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Branch root = new Branch();
            root.branches.Add(new Branch());
            root.branches[0].branches.Add(new Branch());
            root.branches[0].branches[0].branches.Add(new Branch());
            root.branches[0].branches[0].branches[0].branches.Add(new Branch());

            Console.WriteLine("The depth of the tree is " + GetDepth(root, 0) + ".");
            Console.ReadLine();
        }

        static int GetDepth(Branch branch, int depth)
        {
            int maxDepth = depth;

            foreach (Branch b in branch.branches)
            {
                int currentDepth = GetDepth(b, depth + 1);
                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
            }

            return maxDepth;
        }
    }
}
