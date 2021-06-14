using System;
using System.Collections.Generic;

namespace Nickname_Generator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = { "The Hollow", "The Upset", "The Wise", "The Foolish", "The Loud", "The Fearless", "The Thunder", "The Goofy", "The Pathetic", "The Rare", "The Loud", "The Marked" };
            List<string> nicknames = new List<string>();
            nicknames.AddRange(nameArray);

            int length = nicknames.Count;

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            char capital = char.ToUpper(name[0]);
            name = capital + name.Substring(1);

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Please enter a number to select an option");
            Console.WriteLine("1.Change Name");
            Console.WriteLine("2.Display a Random Nickname");
            Console.WriteLine("3.Display All Nicknames");
            Console.WriteLine("4.Add a Nickname");
            Console.WriteLine("5.Remove a Nickname");
            Console.WriteLine("6.Exit");

            string choiceOG = Console.ReadLine();
            try
            {
                int choice = Math.Abs(Convert.ToInt32(choiceOG));

                while (choice <= 5 && choice >= 0)
                {
                    length = nicknames.Count;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine("Please enter your name");
                            name = Console.ReadLine();
                            capital = char.ToUpper(name[0]);
                            name = capital + name.Substring(1);
                            Console.WriteLine("Hello " + name);
                            break;

                        case 2:
                            Random rd = new Random();
                            int randomNum = rd.Next(length);
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine(name + " " + nicknames[randomNum]);
                            break;

                        case 3:
                            Console.WriteLine("___________________________________________________________________");
                            for (int i = 0; i < length; i++)
                            {
                                Console.WriteLine(nicknames[i]);
                            }
                            break;

                        case 4:
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine("Type in a new Nickname");
                            nicknames.Add(Console.ReadLine());
                            Console.WriteLine("Your Nickname   " + nicknames[length] + "   has been added");
                            break;


                        case 5:
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine("What is the nickname you would like to remove?");
                            string removal = Console.ReadLine().ToLower();
                            bool removed = false;
                            for (int i = 0; i < length; i++)
                            {
                                if (nicknames[i].ToLower().Contains(removal))
                                {
                                    removed = true;
                                    nicknames.RemoveAt(i);
                                }
                            }
                            if (removed = true)
                            {
                                Console.WriteLine(removal + " has been removed from the list");
                            }
                            else
                            {
                                Console.WriteLine(removal + " was not found in the list");
                            }
                            break;

                        default:
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine("1.Change Name");
                            Console.WriteLine("2.Display a Random Nickname");
                            Console.WriteLine("3.Display All Nicknames");
                            Console.WriteLine("4.Add a Nickname");
                            Console.WriteLine("5.Remove a Nickname");
                            Console.WriteLine("6.Exit");
                            break;
                    }
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("Please enter a number to select another option or press 0(zero) for a reminder of the options");

                    choiceOG = Console.ReadLine();
                    choice = Math.Abs(Convert.ToInt32(choiceOG));
                }
            }
            catch { Console.WriteLine("Enter a number next time"); }
        }
    }
}

