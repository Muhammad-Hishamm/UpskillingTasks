namespace Task6
{
    internal class Program
    {
        //public static int searchString(string str,ref bool found)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if(found) return -1; // If already found in another thread, exit early
        //        if (i < str.Length - 1 && str[i] == 'T' && str[i + 1] == 'o')
        //        {
        //            found = true;
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        static void Main(string[] args)
        {

            //Task 6.1
            //List<string> lines = new List<string>{ 
            //                                       "Learning To Code Is Super Fun Now!",
            //                                       "Programming Skills Grow  Daily!",
            //                                       "Students Love Creative To Projects"
            //                                     };

            //bool found = false;
            //Thread[] threads = new Thread[lines.Count];

            //for (int i = 0; i < lines.Count; i++)
            //{
            //    int index = i; 
            //    threads[i] = new Thread(() =>
            //    {
            //        if (searchString(lines[index],ref found)!=-1)
            //        {
            //            Console.WriteLine($"Line {index + 1}: {lines[index]}");
            //        }
            //    });
            //    //threads[i].IsBackground = true;
            //    threads[i].Start();
            //}


            ProducerConsumer.main();
        }
    }
}
