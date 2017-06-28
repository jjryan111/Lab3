using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            while (yesNo == "y")
            {
                int input = GetInput();
                Console.WriteLine("Number       Squared         Cubed");
                Console.WriteLine("======       =======         =====");
                for (int i = 1; i <= input; i++)
                {
                    int squared = GetSquare(i);
                    int cubed = GetCube(i);
                    Console.WriteLine(i + "              " + squared + "              " + cubed);
                }
                yesNo = ynInput();
            }
        }
        static int GetSquare(int snum)
        {
            snum = snum * snum;
            return snum;
        }
        static int GetCube(int cnum)
        {
            cnum = cnum * cnum * cnum;
            return cnum;
        }
        static string ynInput()
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input == "n") || (input == "Y") || (input =="N"))
                {
                    invalid = false;
                }
            }
            return input;
        }
        public static int GetInput()
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.WriteLine("Please enter an integer greater than 0 and less than 1290: ");
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum <= 0 || exitNum > 1290)
                {
                    Console.WriteLine("That's not valid input!");
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
    }
}
