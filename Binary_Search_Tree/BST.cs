using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BST
    {
            private Node _root; //member variables
            private int _numNodes;

            public Node Root
            {
                get { return _root; }
            }

            public BST() // constructor
            {
                _root = null;
                _numNodes = 0;
            }



            //returns the number of nodes as a statistic
            public int getNodes()
            {
                return _numNodes;
            }

            //is it empty?
            public bool isEmpty()
            {
                return _root == null;
            }

            //recursively insert the node into the tree
            public bool insert(int data)
            {
                if (isEmpty())
                {
                    _root = new Node(data);
                }
                else
                {
                    _root.insert(ref _root, data);
                }

                _numNodes++;
                return true;
            }

            //prints the tree
            public void PrintTree()
            {
                if (!isEmpty())
                    _root.print(_root);
            }

            //function returns amount of levels in the tree
            public int NumLevels(Node node)
            {

                if (node == null)
                {
                    return 0;
                }
                if (node.Left == null && node.Right == null) //base case
                {
                    return 1;
                }
                if (node.Left == null) //if only left is null, go right
                {
                    return (NumLevels(node.Right) + 1);
                }
                if (node.Right == null) //if only right is null, go left
                {
                    return (NumLevels(node.Left) + 1);
                }
                return (Math.Min((NumLevels(node.Left)), (NumLevels(node.Right))) + 1); //return the result of going down both sides
            }

      



    }
}

