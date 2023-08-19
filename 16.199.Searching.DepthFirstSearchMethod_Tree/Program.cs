using System.Diagnostics;

namespace _16._199.Searching.DepthFirstSearchMethod_Tree
{
    // This version by WBB provides the algorithm and an implementation
    class Node
    {
        public Node? left;
        public Node? right;
        public int data;
    }

    internal class Program
    {
        public void DepthFirstSearchTraversalOnTree(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();

                if (node.right != null)
                {
                    nodes.Push(node.right);
                }

                if (node.left != null)
                {
                    nodes.Push(node.left);
                }

                Debug.WriteLine(node.data + " "); // Print the data value with a space
            }
        }

        public static void Main(string[] args)
        {
            // Constructing a sample binary tree
            Node root = new Node
            {
                data = 1,
                left = new Node
                {
                    data = 2,
                    left = new Node { data = 4 },
                    right = new Node { data = 5 }
                },
                right = new Node
                {
                    data = 3,
                    left = new Node { data = 6 },
                    right = new Node { data = 7 }
                }
            };

            Program program = new Program();
            program.DepthFirstSearchTraversalOnTree(root);
        }
    }
}