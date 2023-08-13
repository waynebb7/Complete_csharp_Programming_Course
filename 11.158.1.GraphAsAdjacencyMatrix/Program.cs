namespace _11._158._1.GraphAsAdjacencyMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Graph
    {
        bool[,] adjacencyMatrix;
        int NumberOfVertices { get; set; }

        public Graph(int size)
        {
            NumberOfVertices = size;
            adjacencyMatrix = new bool[size, size];
        }

        public void AddEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = true;
            adjacencyMatrix[j, i] = true;
        }

        public void RemoveEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = false;
            adjacencyMatrix[j, i] = false;
        }

        public bool IsAdjacent(int i, int j)
        {
            return adjacencyMatrix[i, j];
        }
    }
}