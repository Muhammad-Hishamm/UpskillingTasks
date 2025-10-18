using System;
using System.Collections.Generic;
using System.Threading;

namespace Task6
{
    internal class Program
    {
        public static int SearchString(string line, string keyword, CancellationToken token)
        {
            if (token.IsCancellationRequested) return -1;

            int index = line.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);
            return index;
        }

        static void Main(string[] args)
        {
            List<string> lines = new List<string>
            {
                "Learning To Code Is Super Fun Now!",
                "Programming Skills Grow Daily!",
                "Students Love Creative To Projects"
            };

            string keyword = "To";
            CancellationTokenSource cts = new CancellationTokenSource();
            Thread[] threads = new Thread[lines.Count];

            for (int i = 0; i < lines.Count; i++)
            {
                int index = i;
                threads[i] = new Thread(() =>
                {
                    int result = SearchString(lines[index], keyword, cts.Token);
                    if (result != -1)
                    {
                        Console.WriteLine($" Found in Line {index + 1}: {lines[index]}");
                        cts.Cancel(); 
                    }
                });
                threads[i].Start();
            }

            
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Search completed.");
        }
    }
}