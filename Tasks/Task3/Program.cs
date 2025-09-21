namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            //foreach (int i in arr)
            //{
            //    Console.Write(i.ToString()+" ");
            //}

            //Console.WriteLine();
            //ArrayUtils.ReverseArray(ref arr);

            //foreach (int i in arr)
            //{
            //    Console.Write(i.ToString() + " ");
            //}

            //Console.WriteLine(ArrayUtils.FindMax(arr));
            Cache<string, int> students= new Cache<string, int>(3);

            students.Add("Muhammad", 123);
            students.Add("ahmed", 466);
            students.Add("ali", 888);

            Console.WriteLine("Displaying before retrieving any element");

            students.DisplayAll();
            students.Retrieve("ali");
            students.Reomve("Muhammad");
            students.Add("mona", 1);

            Console.WriteLine("Displaying after retrieving ali and removing Muhammad");
            students.DisplayAll();


        }
    }
}
