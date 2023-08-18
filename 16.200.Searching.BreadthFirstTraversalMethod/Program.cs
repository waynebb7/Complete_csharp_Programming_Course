using System.Diagnostics;

namespace _16._200.Searching.BreadthFirstTraversalMethod
{
    class Node
    {
        public Node left;
        public Node right;
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
                if(node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
            }
        }

        public HashSet<int> BreadthFirstTraverseOnGraph(Node root)
        {
            HashSet<int> visited = new HashSet<int>();

            if(!graph.AdjacencyList.ContainsKey(root))
            {
                return visited;
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(root.data);
            while (q.Count > 0)
            {
                int vertex = q.Dequeue();

                if (visited.Contains(vertex))
                {
                    continue;
                }

                visited.Add(vertex);

                foreach(var neighbor in graph.AdjacentList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        q.Enqueue(neighbor);
                    }
                }
            }

            return visited;
        }

        static void Main(string[] args)
        {
        }
    }
}