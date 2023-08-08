namespace _4._45.operator_overloading
{
    class Box
    {
        //declarations
        private int length;
        private int width;
        private int height;

        //constructor for the Box class
        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //getter / setter functions
        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(),
                           box1.GetHeight() + box2.GetHeight(),
                           box1.GetWidth() + box2.GetHeight());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(2,2,2);
            Box box2 = new Box(2,2,2);
            Box box3 = box1 + box2;

            System.Diagnostics.Debug.WriteLine("Length: " + box3.GetLength());
            System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());
            System.Diagnostics.Debug.WriteLine("Width: " + box3.GetWidth());
        }
    }
}