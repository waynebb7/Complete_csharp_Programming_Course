namespace _11._158.Graphs___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            Graph graph = new Graph(6);

            graph.AddEdge(six, four);
            graph.AddEdge(four, three);
            graph.AddEdge(four, five);
            graph.AddEdge(five, one);
            graph.AddEdge(five, two);
            graph.AddEdge(four, three);
            graph.AddEdge(three, two);
            graph.AddEdge(two, one);
        }
    }

    class Node
    {
        public List<object> Neighbours { get; set; }
        public int Data;

        public Node(int data) 
        {
            Data = data;
        }
    }

    class Graph
    {
        public int NumberOfVertices { get; set; }
        public List<Node> Vertices { get; set; }

        public Graph(int size)
        {
            NumberOfVertices = size;
            Vertices = new List<Node>();

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Vertices[i] = new Node();
            }
        }

        public void AddEdge(Node source, Node destination)
        {
            source.Neighbours.Add(destination);
            destination.Neighbours.Add(source);
        }

        public void RemoveEdge(Node source, Node destination)
        {
            source.Neighbours.Remove(destination);
            destination.Neighbours.Remove(source);
        }

        public bool IsAdjacent(Node node1, Node node2)
        {
            return node1.Neighbours.Contains(node2);
        }
    }
}