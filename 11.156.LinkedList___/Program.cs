namespace _11._156.LinkedList___
{
    internal class Program
    {
        public class LinkedList
        {
            public class Node
            {
                public Node next;
                public object data;
            }

            private Node root;

            public Node First { get { return root; } }

            public Node Last
            {
                get
                {
                    Node currentNode = root;
                    if (currentNode == null)
                    {
                        return null;
                    }

                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    return currentNode;
                }
            }
            public void Append(object value)
            {
                Node node = new Node { data = value };
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }

            public void Delete(Node node)
            {
                if (root == null)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while (current.next != null)
                    {
                        if (current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
        }
    }
}