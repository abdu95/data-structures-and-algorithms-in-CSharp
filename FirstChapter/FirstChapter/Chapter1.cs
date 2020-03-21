using System;

namespace FirstChapter
{
    public class Chapter1
    {
        static void Main()
        {
            Collection names = new Collection();
            names.Add("David");
            names.Add("Sarah");
            names.Add("Raymond");
            names.Add("Clayton");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of names in the collection: " + names.Count());
            names.Remove("Raymond");
            Console.WriteLine("Number of names in the collection: " + names.Count());
            names.Clear();
            Console.WriteLine("Number of names in the collection: " + names.Count());
            Console.ReadLine();
            //add comment
        }
    }
}
