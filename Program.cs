using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a comment
            /*
             This is
             a
             multi line comment.
             */

            /*****************************Printing to the console************************************/

            Console.Write("Cursor"); //Console.Write() will hold the cursor on the same line

            Console.WriteLine(" is held on the same place.");  //Console.WriteLine() will move
                                                               //the cursor to the new line
            Console.WriteLine("Hello World");

            /*Console.Read();*/ //Asking the console to wait for us to read line.
                                //If this line is not written then the console will be closed immediatly.
                                //Here the program will be terminated and it will not read from here onwards
                                //Console.ReadLine() will also serve the same purpose

            /**************************************************************************************/


            /***********************************Variable in C#************************************/

            int num1;             //variable declaration 
            num1 = 100;           //variable initialization
            int num2 = 200;       //declaration and initialization in the same line
            Console.WriteLine("The value of the integer variables are " + num1 + " and " + num2 + "."); //Printing variable
            float floating_Value = 43.19f; //f is must in floating variables
            double double_Value = 43837.3729899421D; // can also be written as double double_Value = 43837.3729899421d; or /D
            Console.WriteLine(floating_Value);
            Console.WriteLine(double_Value);

            /*
             Other data types include:
            int a = 10; --> 4 bytes
            long b = 2403493038; --> 8 bytes
            float f = 1.0f; --> 4 bytes
            double dec; --> 8 bytes
            string str = "Hello World";  --> 2 bytes per character
            boolean flag = ture; --> 1 bit
            char a = 'A'; --> 2 bytes
             */

            /**************************************************************************************/

            /***********************************Taking User input**********************************/

            string str = Console.ReadLine();  //Console.ReadLine returns a string
            Console.WriteLine("You Entered: " + str);

            /**************************************************************************************/

            /************************************Type Casting**************************************/

            // There are 2 types of type casting:
            // 1) Implicit
            // 2) Explicit 
            // valid order of typecasting
            // char --> int --> long --> float --> double

            Console.Write("Example of implicit type casting.\n\n"); // \n in the new line character

            char ch = 'a';
            int ch_Value = ch;  //Implicit type casting, ch_Value = 97 i.e the ascii value of 'a'
            //Similarly
            double ch_Double_Value = ch; 
            long ch_Long_Value = ch;
            float ch_Float_Value = ch;

            Console.WriteLine("Character: " + ch);
            Console.WriteLine("Character integer value: "+ ch_Value);
            Console.WriteLine("Character double Value: " + ch_Double_Value);
            Console.WriteLine("Character long value: " + ch_Long_Value);
            Console.WriteLine("Character float value: " + ch_Float_Value);


            Console.Write("\nExample of explicit type casting.\n\n"); // \n in the new line character

            
            float floating_Value1 = 43.19f; 
            int num3 = (int) floating_Value1;
            Console.WriteLine("The value of floating variable is :" + floating_Value1);
            Console.WriteLine("Floating value explicity typecasted to integer: " + num3);
            string num_to_String = Convert.ToString(num3);
            Console.WriteLine("Integer value converted to string with the help of built in Convert functions : " + num_to_String);

            /**************************************************************************************/

            /**************************************Math class in C#********************************/

            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Min is:" + Math.Min(a, b));
            Console.WriteLine("Max is:" + Math.Max(a, b));
            Console.WriteLine("Squaroot of first value is is:" + Math.Sqrt(a));

            /**************************************************************************************/

            /*********************************String in C#*****************************************/

            Console.WriteLine("Enter your name:-");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}."); //This is called string interpolation
            Console.WriteLine($"The length of your name is {name.Length}.");
            Console.WriteLine($"Your name in uppercase Letters is {name.ToUpper()}.");
            Console.WriteLine($"Your name is lowercase letter is {name.ToLower()}.");
            Console.WriteLine("Enter your Age:-");
            string age = Console.ReadLine();
            Console.WriteLine($"Your username is {string.Concat(name.ToLower(),(Convert.ToInt32(age)+name.Length))}");

            /**************************************************************************************/

            /*************************************OOP in C#****************************************/

            //object of class player

            Player player1 = new Player(21);
            player1.Printage();
            Console.ReadLine();
        }
    }
}
