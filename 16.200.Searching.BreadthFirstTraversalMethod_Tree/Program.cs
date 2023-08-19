using System.Diagnostics;

namespace _16._200.Searching.BreadthFirstTraversalMethod_Tree
{
    class Node
    {
        public Node? left;
        public Node? right;
        public int data;
    }

    internal class Program
    {
        public void BreadthFirstTraversalOnTree(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();
            if (root == null)
            {
                return;
            }

            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Dequeue();
                Debug.WriteLine(" " + node.data);
                if (node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
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
            program.BreadthFirstTraversalOnTree(root);
        }
    }

}