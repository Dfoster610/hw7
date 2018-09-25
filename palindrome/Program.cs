using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                    
                    Console.WriteLine("Enter text to see if it’s a palindrome:");
                    string text = Console.ReadLine();
                    
                do
                {

                    char[] characters = text.ToCharArray();
                    Array.Reverse(characters);
                    string palindrome = new string(characters);

                    if (text.ToLower().Equals(palindrome.ToLower()))
                        Console.WriteLine("Your text is a Palindrome");
                    else 
                        Console.WriteLine("You text is Not a Palindrome");
                    
                    text = Console.ReadLine();
                    if (text.ToLower() == "exit")
                        break;

                }
                while (true);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

}
    }
}
