using System.Diagnostics;

namespace _1._146._1.Stacks___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Debug.WriteLine(stack.Pop());
            Debug.WriteLine(stack.Pop());
            Debug.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {
        const int MAX = 1000;
        int top;
        object[] stack = new object[MAX];

        public Stack()
        {
            top = -1;
        }

        public void Push(object obj)
        {
            if (top < MAX)
            {
                stack[++top] = obj;
            }
        }

        public object Pop()
        {
            if (top >= 0)
            {
                object o = stack[top];
                top--;
                return o;
            }
            else
            {
                return -1;
            }
        }

        public object Peek()
        {
            return stack[top];
        }
    }
}