using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string Name = Console.ReadLine();
            Name = Name.ToUpper();
            Name = Name.Trim();
            Console.WriteLine(Initials(Name));
            Console.ReadLine();

        }
        public static string Initials(string Name)
        {
            string splitName = Name;
            string[] split = splitName.Split(' ');
            foreach (string item in split)
            {
                item.Remove(1);
                Console.WriteLine(item.Remove(1));
            }
                Console.ReadLine();
                return "";
            }


            // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        }
    }

