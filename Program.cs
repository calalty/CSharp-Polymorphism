using System;

namespace Polymorphism
{
    class UserInput 
    {
        /*

        Static Polymorphism... what we've done below... Overloading our method...
        Forced it to run a partical method as it takes the data in...

        Dynamic... runtime... taking data on the fly and running methods...
        
        */

        public void ShowUserInput(int userData)
        {
            Console.WriteLine($"the user inputted ainteger: {userData}");
        }
        public void ShowUserInput(string userData)
        {
            Console.WriteLine($"the user inputted a string: {userData}");
        }
        public void ShowUserInput(double userData)
        {
            Console.WriteLine($"the user inputted a double: {userData}");
        }

        /* 
        challenge:
        take multiple data types in methods with the same name and convert them into at least 3 different types
        input string + string > convert them into a type of your choice and display them (done)
        input string + int > convert them into a type of your choice and display them (done)
        input bool + float > convert them into a type of your choice (done)
        input decimal + decimal > convert them into a type of your choice (done)
        
        Extension:
        incoporate encapsulation into this...
        public method that will run private polymorphic methods with the data that is inputted (done)
        */ 

        private string numberOne;
        private string numberTwo;
        public void Addition()
        {
            numberOne = "333";
            numberTwo = "333";

            Console.WriteLine("Addition of 2 Strings to Integer:");
            Console.WriteLine(Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo));
            
        }
        public void Addition(string numberOne, int numberTwo)
        {
            Console.WriteLine("Addition of a String and Integer to Integer:");
            Console.WriteLine(Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo));
        }
        public void Addition(bool numberOne, float numberTwo)
        {
            Console.WriteLine("Addition of Bool and Float to Decimal:");
            Console.WriteLine(Convert.ToDouble(numberOne) + Convert.ToDouble(numberTwo));
        }
        public void Addition(decimal numberOne, decimal numberTwo)
        {
            Console.WriteLine("Addition of 2 Decimals to Float:");
            Console.WriteLine(Convert.ToSingle(numberOne) + Convert.ToSingle(numberTwo));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput newUser = new UserInput();
            newUser.ShowUserInput(123);
            newUser.ShowUserInput("Cal");
            newUser.ShowUserInput(123.123);
            // encapsulated - newUser.Addition("3333", "9999");
            newUser.Addition("3333", 9999);
            newUser.Addition(true, 9.2f);
            newUser.Addition(4.5m, 6.5m);
            newUser.Addition(); // encapsulated method
    }}
}