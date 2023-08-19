using System.Diagnostics;

namespace _16._199.Searching.DepthFirstSearchMethod
{
    class Node
    {
        public Node left;
        public Node right;
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

                Debug.WriteLine(" " + node.data);
            }
        }

        public HashSet<int> DepthFirstSearchTraversalOnGraph(Node root)
        {
            HashSet<int> visited = new HashSet<int>();
            if (!graph.AdjacencyList.ContainsKey(root))
            {
                return visited;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(root.data);

            while (stack.Count > 0)
            {
                int vertex = stack.Pop();

                if (visited.Contains(vertex))
                {
                    continue;
                }

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
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