using System.Diagnostics;

namespace _16._199.Searching.DepthFirstSearchMethod_Graph
{
    // This version by WBB provides the algorithm and an implementation
    class Node
    {
        public int data;
    }

    class Graph
    {
        public Dictionary<int, List<int>> AdjacencyList { get; set; }
    }

    internal class Program
    {
        public HashSet<int> DepthFirstSearchTraversalOnGraph(Node root, Graph graph)
        {
            HashSet<int> visited = new HashSet<int>();
            if (!graph.AdjacencyList.ContainsKey(root.data))
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

        public static void Main(string[] args)
        {
            Program program = new Program();

            // Create a sample graph
            Graph graph = new Graph
            {
                AdjacencyList = new Dictionary<int, List<int>>
            {
                { 1, new List<int> { 2, 3 } },
                { 2, new List<int> { 4, 5 } },
                { 3, new List<int> { 6, 7 } },
                { 4, new List<int> { 8, 9 } },
                { 5, new List<int> { 10 } },
                { 6, new List<int>() },
                { 7, new List<int>() },
                { 8, new List<int>() },
                { 9, new List<int>() },
                { 10, new List<int>() }
            }
            };

            Node rootNode = new Node { data = 1 };
            HashSet<int> visitedNodes = program.DepthFirstSearchTraversalOnGraph(rootNode, graph);

            Debug.WriteLine("Visited nodes:");
            foreach (var node in visitedNodes)
            {
                Debug.WriteLine(node);
            }
        }
    }
}