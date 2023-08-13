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

            a.SetLeft(b);
            a.SetRight(c);

            PreOrder(a);

            InOrder(a);

            PostOrder(a);
        }
        // PreOrder
        static void PreOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                Debug.WriteLine(root.GetValue().ToString());
                PreOrder(root.GetLeft());
                PreOrder(root.GetRight());
            }
        }

        // InOrder
        static void InOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                InOrder(root.GetLeft());
                Debug.WriteLine(root.GetValue().ToString());
                InOrder(root.GetRight());
            }

        }

        // PostOrder
        static void PostOrder(TreeNode<string> root)
        {
            if (root != null)
            {                
                PostOrder(root.GetLeft());
                PostOrder(root.GetRight());
                Debug.WriteLine(root.GetValue().ToString() + " ");
            }
        }

        // IsBalanced
        static bool IsBalanced(TreeNode<string> root)
        {
            int diff = 0;
            if((root.GetLeft() != null && root.GetRight() == null) ||
                root.GetLeft() != null && root.GetRight() != null)
            {
                diff += 1;
            }
            else
            {
                diff = 0;
            }

            return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
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