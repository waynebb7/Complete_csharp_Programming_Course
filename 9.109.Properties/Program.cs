namespace _9._109.Properties
{
    internal class Program
    {
        //private int myVar1;

        //public int MyVar1 { get => myVar1; set => myVar1 = value; }

        private string id;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.id = "1234";
            System.Diagnostics.Debug.WriteLine(program.Id);
        }
    }
}