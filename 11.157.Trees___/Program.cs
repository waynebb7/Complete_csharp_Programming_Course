using System.Diagnostics;

namespace _11._157.Trees___
{
    class Example
    {
        static void Main(string[] args)
        {
            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");
            TreeNode<string> d = new TreeNode<string>("d");
            TreeNode<string> e = new TreeNode<string>("e");
            TreeNode<string> f = new TreeNode<string>("f");
            TreeNode<string> g = new TreeNode<string>("g");

            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            b.SetRight(e);
            c.SetLeft(f);
            c.SetRight(g);

            Debug.WriteLine(Program<string>.GetHeight(a));
        }
    }

    public class Program<T>
    {
        public static int GetHeight(TreeNode<T> root)
        {
            if (root == null) { return 0; }
            return Math.Max(GetHeight(root.GetLeft()), GetHeight(root.GetRight()) + 1);
        }
    }
    public class TreeNode<T>
    {
        T value;
        TreeNode<T> left = null;
        TreeNode<T> right = null;

        public TreeNode(T value)
        {
            this.value = value;
        }

        public TreeNode<T> GetLeft()
        {
            return left;
        }

        public TreeNode<T> GetRight()
        {
            return right;
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public void SetRight(TreeNode<T> node)
        {
            right = node;
        }

        public void SetLeft(TreeNode<T> node)
        {
            left = node;
        }
    }
}