using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

            //Through Linq and lamba I created a sorted list that is sorting my items via alphabet lambda is awesome!

            var sortedlist = myGames.OrderBy
                (x => x); foreach (var game in sortedlist) Console.WriteLine(game);

            Console.WriteLine("------------");

            var result = myGames.OrderBy(x => x.Length); foreach (var game in result) Console.WriteLine(game);

            //I googled and found out the "var result = list.OrderBy(x => x.Length)" does the length of item of a list to sort.




            //Explicit typing you can also use
            // var sortedList = sortedlist.OrderBy(x => x);    



            //Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
            //use Method Syntax for this exercise
        }
    }
}
