using System.Diagnostics;

namespace _16._201.Searching.TreeTraversal
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
    }

    internal class Program
    {
        static void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Debug.WriteLine(root.Data);
                InOrder(root.Right);
            }
        }

        static void PreOrder(Node root)
        {
            if (root != null)
            {
                Debug.WriteLine(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        static void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Debug.WriteLine(root.Data);
            }
        }

        static void Main(string[] args)
        {
            Node leftNode = new Node()
            {
                Data = 1,
                Left = null,
                Right = null
            };

            Node rightNode = new Node()
            {
                Data = 3,
                Left = null,
                Right = null
            };

            Node root = new Node()
            {
                Data = 2,
                Left = leftNode,
                Right = rightNode
            };

            InOrder(root);
            PreOrder(root);
            PostOrder(root);
        }
    }
}