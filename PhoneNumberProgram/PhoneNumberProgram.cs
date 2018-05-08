using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace PhoneNumberProgram
{
    class PhoneNumberProgram
    {
        static void Main(string[] args)
        {
            Restart:
            CT.Header(out CT.LengthOfTopLine, "Ch. 5 Program 10", " to re-do "
                + "the phone number prgm with arrays");

            string[] DisplayNum = new string[10];

            #region Mitch's Code
            /*Mitch take the stuff commented out right now...
             its the right code for you... the rest is an even better way to do it...
             DONT FORGET THE THREE METHODS AT THE BOTTOM!!!!!!



            List<string> OriginalNumbers = new List<string>();            

            CT.Color("");
            for (int i = 0; i < 10; i++)
            {
                string x = "Digit #" + (i + 1).ToString();
                OriginalNumbers.Add(AskUserForString(x));
            }

            DisplayNum = OriginalNumbers.ToArray();

            Console.WriteLine("\n\nThe original phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);
            CT.Color("");

            List<string> NewNumbers = new List<string>();

            foreach (string num in OriginalNumbers)
            {
                NewNumbers.Add(ConvertToPhoneNumberEquivalent(num));
            }

            DisplayNum = NewNumbers.ToArray();

            Console.WriteLine("\n\nThe useable phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);

            Console.WriteLine();
            CT.AnyKeyToContinue();
            Console.Clear();
            */

            //End of Reg Prgm
            //The rest is just messing around
            #endregion

            List<string> OriginalNumbers2 = new List<string>();

            string phoneNumber = CT.AskUserForString("the phone number with no spaces");

            phoneNumber = phoneNumber.Trim();

            while (phoneNumber.Contains(" ") || (phoneNumber.Contains("-")) || (phoneNumber.Length != 10))
            {
                CT.Color("red");
                Console.WriteLine("Please enter the phone number in the correct format!!");
                phoneNumber = CT.AskUserForString("the phone number with no spaces");                
            }

            for (int i = 0; i < 10; i++)
            {
                OriginalNumbers2.Add(phoneNumber.Substring(i, 1));
            }

            DisplayNum = OriginalNumbers2.ToArray();

            int counter = 0;
            foreach (string check in OriginalNumbers2)
            {                
                string intialNum = check;
                string checkedNum = "";
                checkedNum = CheckNum2(check);
                if (intialNum != checkedNum)
                {
                    DisplayNum[counter] = checkedNum;
                }
                
                counter++;
            }                      

            Console.WriteLine("\n\nThe original phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);
            CT.Color("");

            List<string> NewNumbers2 = new List<string>();

            foreach (string num in DisplayNum)
            {
                NewNumbers2.Add(ConvertToPhoneNumberEquivalent(num));
            }

            DisplayNum = NewNumbers2.ToArray();

            Console.WriteLine("\n\nThe useable phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("If you wish to enter another number, enter <-911>:");
            string input = Console.ReadLine();
            if (input == "-911")
            {
                Console.Clear();
                goto Restart;
            }
            CT.Footer();
        }

        public static string CheckNum2(string x)
        {
            //This used to check if the input is anything other 
            //than the desired charachters and numbers
            
            //THIS CHECK IS EXECUTED IN THE GETTING INPUT METHOD
            switch (x.ToLower())
            {
                case "1":
                case "a":
                case "b":
                case "c":
                case "2":
                case "d":
                case "e":
                case "f":
                case "3":
                case "g":
                case "h":
                case "i":
                case "4":
                case "j":
                case "k":
                case "l":
                case "5":
                case "m":
                case "n":
                case "o":
                case "6":
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                case "t":
                case "u":
                case "v":
                case "8":
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                case "0":
                    break;
                default:
                    CT.Color("red");
                    Console.WriteLine("You entered {0}, which is not valid...", x);
                    x = AskUserForString("a VALID charachter");
                    break;

            }
            return x;
        }

        //Also Mitch TAKE THESE NEXT THREE METHODS
        public static string AskUserForString(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            CT.Color("Green");
            string input = Console.ReadLine();
            CT.Color("");
            input = CheckNum(input);
            return input;
        }

        public static string CheckNum(string x)
        {
            //This used to check if the input is anything other 
            //than the desired charachters and numbers

            //THIS CHECK IS EXECUTED IN THE GETTING INPUT METHOD
            switch (x.ToLower())
            {
                case "1":
                case "a":
                case "b":
                case "c":
                case "2":
                case "d":
                case "e":
                case "f":
                case "3":
                case "g":
                case "h":
                case "i":
                case "4":
                case "j":
                case "k":
                case "l":
                case "5":
                case "m":
                case "n":
                case "o":
                case "6":
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                case "t":
                case "u":
                case "v":
                case "8":
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                case "0":
                    break;
                default:
                    x = AskUserForString("only one digit at a time for the digit above");
                    break;

            }
            return x;
        }

        public static string ConvertToPhoneNumberEquivalent(string x)
        {
            switch (x.ToLower())
            {
                case "1":
                    x = "1";
                    break;
                case "a":
                case "b":
                case "c":
                case "2":
                    x = "2";
                    break;
                case "d":
                case "e":
                case "f":
                case "3":
                    x = "3";
                    break;
                case "g":
                case "h":
                case "i":
                case "4":
                    x = "4";
                    break;
                case "j":
                case "k":
                case "l":
                case "5":
                    x = "5";
                    break;
                case "m":
                case "n":
                case "o":
                case "6":
                    x = "6";
                    break;
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                    x = "7";
                    break;
                case "t":
                case "u":
                case "v":
                case "8":
                    x = "8";
                    break;
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                    x = "9";
                    break;
                case "0":
                    x = "0";
                    break;

            }


            return x;
        }
    }
}
