using System;

namespace ListObject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            System.Console.WriteLine(names.Count);
            names.Add("enes");
            names.Add("elif");
            names.Add("necibe");
            names.Add("mehmet");
            System.Console.WriteLine(names.Count);
            System.Console.WriteLine(names[2]);

            string[] namesCopy = names.CopyTo();
            namesCopy[0] = "sonmez";
            System.Console.WriteLine(names[0]);
            System.Console.WriteLine(namesCopy[0]);

            System.Console.WriteLine(names.IndexOf("necbe"));

            names.Insert(1,"kamil");
            for (int i = 0; i < names.Count; i++)
            {
                System.Console.WriteLine(names[i]);
            }

            names.RemoveAt(2);
            for (int i = 0; i < names.Count; i++)
            {
                System.Console.WriteLine(names[i]);
            }
        }
    }
}