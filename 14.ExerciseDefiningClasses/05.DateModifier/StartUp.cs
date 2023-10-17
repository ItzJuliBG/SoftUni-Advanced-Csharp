using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier dateModifier = new DateModifier(firstDate, secondDate);
            Console.WriteLine(dateModifier.CalculateDifference());


        }
    }
}
