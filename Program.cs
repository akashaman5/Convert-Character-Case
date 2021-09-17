using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Convert_Character_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "©Akash Aman";  //customize the app title window.


            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;

            Console.ForegroundColor = ConsoleColor.Blue;  //make the console output as blue.

            Console.Write("\nReplace lower-case Cosmos ID by upper-case and vice-versa :\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\nInput the Cosmos ID : ");

            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // Converts string into char array.

            Console.ForegroundColor = ConsoleColor.White;     //make the console output as white.
            Console.Write("\nAfter the case conversion, Cosmos ID is: ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // check whether the character is lowercase
                    Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
                else
                    Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
            }

            Console.ForegroundColor = ConsoleColor.Blue;  //make the console output blue again.

            Console.WriteLine("\n\n\n\nDo that again?   Press 'y' and then hit ENTER\n"); //retry input without restarting the app.

            String SelectedKey = Console.ReadLine();      //store the user's response for input retry.

            if (SelectedKey == "y")
            {
                // clear the screen and reset the app by calling main method.

                Console.Clear();
                Main(args);

            }

            Console.ForegroundColor = ConsoleColor.Blue;  //make the console output blue again.
            Console.WriteLine("\n\nPress any key to exit....");

            //Console.ReadKey();

            //Console.Write("\n\n");
            //Console.ReadLine();
        }
    }
}
