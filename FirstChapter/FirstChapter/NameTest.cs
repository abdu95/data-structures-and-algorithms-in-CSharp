using System;

namespace FirstChapter
{
    public class NameTest
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            //Name myName = new Name();
            //myName.firstName = "Abdu";
            //Console.WriteLine(myName.firstName);
            Name myName = new Name("Abduvosid", "Abduvaxob o'g'li", "Malikov");
            string fullName, inits;
            fullName = myName.ToString();
            inits = myName.Initials();
            Console.WriteLine("My name is {0}", myName);
            Console.WriteLine("My initials are: {0}", inits);
            Console.ReadLine();
        }
    }
}
