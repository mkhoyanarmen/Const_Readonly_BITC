using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly
{
    internal class Program
    {
        const string CORRECT_PASSWORD = "basicItCenter";
        enum WeekDays
        {
            Monday = 1,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static readonly WeekDays weekDays = WeekDays.Tuesday;
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("Enter the password");
                string enteredPass = Console.ReadLine();
                switch (enteredPass)
                {
                    case CORRECT_PASSWORD:
                        Console.WriteLine("Password is correct");
                        Console.WriteLine($"You logged in on the {(int)weekDays} day ({weekDays}) of the week");
                        t = false;
                        break;
                    default:
                        Console.WriteLine("Password is incorrect\n");
                        break;
                }
            }
        }
    }
}
