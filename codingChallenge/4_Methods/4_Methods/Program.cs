using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/


         static string GetName()
        {
            // throw new NotImplementedException("GetName() is not implemented yet0");
            Console.WriteLine("Hello, what is your name?");
            string username = Console.ReadLine();
            return username;
            }

        static string GreetFriend(string name)
        {
            // throw new NotImplementedException("GreetFriend() is not implemented yet");
            Console.WriteLine("Hello, " + username + "You are my friend.");
        }

        static double GetNumber()
        {
            // throw new NotImplementedException("GetNumber() is not implemented yet");
            Console.WriteLine("Get Number: ");
            double getNum = Convert.ToDouble(Console.ReadLine());
        }

        static int GetAction()
        {
                // throw new NotImplementedException("GetAction() is not implemented yet");
                Console.WriteLine("Select 1 to add, 2 to subtract, 3 to multiply, or 4 to divide.");
                int getAction = Convert.ToInt32(Console.ReadLine());
                if (getAction == 1)
                {
                    result = GetNumber() + GetNumber;
                }
                if else (getAction == 2)
                {
                    result = GetNumber() - GetNumber;
                }
                if else (getAction == 3)
                {
                    result = GetNumber() * GetNumber;
                }
                else (getAction == 4)
                {
                    result = GetNumber() / GetNumber;
                }

            }

        static double DoAction(double x, double y, int action)
        {
                // throw new NotImplementedException("DoAction() is not implemented yet");

                GetAction(x, y, action);

        }
    
}
