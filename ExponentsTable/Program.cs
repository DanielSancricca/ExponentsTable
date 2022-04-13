using System;

namespace ExponentsTable
{
    class Program
    {
        public static void Main()
        {
            bool goAgain = true;
            while (goAgain == true)
            {
                Console.WriteLine("Please enter an integer.");
                int userInput = int.Parse(Console.ReadLine());



                if (userInput > 0 && userInput <= 1290)
                {
                    Console.WriteLine("Number" + "\t" + "Square" + "\t" + "Cubed");
                    Console.WriteLine("=======" + "\t" + "=======" + "\t" + "=======" + "\t");
                }
                else
                {
                    Console.WriteLine("I'm sorry we cannot use that number.");
                    continue;
                }
                int square, cube;
                for (int i = 1; i <= userInput; i++)

                {
                    square = (int)Math.Pow(i, 2);
                    cube = (int)Math.Pow(i, 3);
                    //tried to align numbers to the right by converting to string
                    //this comes out the same as Console.WriteLine(i + "\t" + square + "\t" + cube + "\t");
                    string msg = (i + "\t" + square + "\t" + cube + "\t");
                    String.Format("{0,5}", msg);
                    Console.WriteLine(msg);

                }
               

                

                while (true)
                { 

                    Console.WriteLine("Would you like to run the application again? y/n");
                    string userResponse = Console.ReadLine();
                    if (userResponse.ToLower() == "y")
                    {
                        break;
                    }
                    else if (userResponse.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        goAgain = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I don't understand that answer please enter y or n.");
                        continue;
                    }
                }





            }
        }
    }
}
