using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SimpleJRECodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            List<string> epList = new List<string>();
            Console.WriteLine("JRE number list generator!");
            Console.WriteLine();
            Console.WriteLine("From number");
            string i = Console.ReadLine();
            Console.WriteLine("To number");
            string ganger = Console.ReadLine();

            int i1 = Int32.Parse(i);
            int ganger1 = Int32.Parse(ganger);

            for (i1 = i1; i1 <= ganger1; i1++)
            {
                epList.Add($"#{i1}*");
            }
            File.WriteAllLines($@"{user}\Desktop\List.txt", epList);

            Console.WriteLine("List file is on your dektop");
            Thread.Sleep(2000);
        }
    }
}
