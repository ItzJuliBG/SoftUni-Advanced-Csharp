using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;
        private string differenceInDays;

        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }
        public DateModifier(string firstDate, string secondDate, string differenceInDays)
            :this(firstDate,secondDate)
        {

            this.DifferenceInDays = differenceInDays;
        }

        public string FirstDate { get => firstDate; set => firstDate = value; }
        public string SecondDate { get => secondDate; set => secondDate = value; }
        public string DifferenceInDays { get => differenceInDays; set => differenceInDays = value; }


        public int CalculateDifference()
        {
            List<int> first = FirstDate.Split().Select(int.Parse).ToList();
            List<int> second = SecondDate.Split().Select(int.Parse).ToList();
            DateTime fd = new DateTime(first[0], first[1], first[2]);
            DateTime sd = new DateTime(second[0], second[1], second[2]);
            TimeSpan diff = sd.Subtract(fd);

            return Math.Abs(diff.Days);
        }
    }
}
