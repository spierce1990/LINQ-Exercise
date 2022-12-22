using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var myGames = new List<string>() {"supermario", "peggle", "lordoftherings" , "mortalcombat"};

            //   Create a list of video game names...


            IEnumerable<string> sortedlist = myGames.OrderBy(x => x); //Explicit typing you can also use
            // var sortedList = sortedlist.OrderBy(x => x);    


            foreach (var x in myGames)
            {
                Console.WriteLine(x);
            }


//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise
        }
    }
}
