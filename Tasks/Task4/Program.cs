namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStringCollection mylist = new MyStringCollection();

            mylist.Add("Hello");
            mylist.Add("Teka");
            mylist.Remove("pp");
            Console.WriteLine( mylist.Contains("Hello"));
            mylist.Add("Muhammad");
            mylist.Add("Hisham");

            mylist.PrintAll();
        }
    }
}
