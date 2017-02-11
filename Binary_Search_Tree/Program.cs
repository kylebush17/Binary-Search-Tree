using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST b = new BST();
            Console.Write("Please enter any number of integers on the scale [0,100] to be inserted into the Tree: ");
            string numbers = Console.ReadLine();//read numbers
            string[] splitNumbers = numbers.Split(' ');//split string using ' ' delimeter
            foreach (string num in splitNumbers) //for each to convert each string to an int then insert it
            {
                int treeEntry = Int32.Parse(num);

                b.insert(treeEntry);
            }

            Console.Write("Tree Contents: ");
            b.PrintTree(); //recursively print tree
            Console.Write("\nTree Statistics: \n");
            Console.Write("Number of Nodes: " + b.getNodes());
            int levels = b.NumLevels(b.Root);//get the levels
            Console.Write("\nNumber of levels: " + levels);
            Console.Write("\nMinimum number of levels a tree with " + b.getNodes() + " nodes could have is: " + (b.getNodes() / 2));
            Console.Write("\nDone\n");
        }
    }
}
