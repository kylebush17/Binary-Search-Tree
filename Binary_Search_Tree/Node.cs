using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        //member variables
        private int _contents;
        private Node _leftNode;
        private Node _rightNode;

        //constructor that only accepts an integer to initialize contents of the node
        public Node(int data)
        {
            _contents = data;
            _leftNode = null;
            _rightNode = null;
        }

        //recursively insert a node into a tree using a reference to a node and data
        public void insert(ref Node node, int data)
        {
            if (node == null) //used to check if tree is empty
                node = new Node(data);
            else if(node._contents > data)//need to go left
            {
                
                if(node._leftNode == null )//is there already a left node?
                {
                    node._leftNode = new Node(data);
                }
                else
                {
                    insert(ref node._leftNode, data);//already a left node, go left again
                }
                
            }
            else if(node._contents < data)//need to go right
            {
              
                if(node._rightNode == null)//right node?
                {
                    node._rightNode = new Node(data);
                }
                else
                {
                    insert(ref node._rightNode, data);//go right again
                }
               
            }
          
           
        }

        //in order traversal through the tree to print contents in order
        public void print(Node node)
        {

            if (node == null)
            {
                return;
            }
            
            if(node._leftNode!=null)//go all the way left
            {
                print(node._leftNode);
            }

            Console.Write(" " + node._contents);//begin printing

            if (node._rightNode!= null)//go all the way right
            {
                print(node._rightNode);
            }
            
        }

        //getters to return left and right nodes for use
       public Node Right
        {
            get { return _rightNode; }
            set { Right = value; }
        }
        public Node Left
        {
           get { return _leftNode; }
           set { Left = value; }
        }
        
        public int Contents
        {
            get { return _contents; }
        }

    
    }
}
