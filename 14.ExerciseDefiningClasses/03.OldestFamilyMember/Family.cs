using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> member;


        public Family(List<Person> member)
        {
            this.Member = member;
        }

        public List<Person> Member { get => member; set => member = value; }
        public void AddMember(Person member)
        {
            Member.Add(member);
        }
        public Person GetOldestMember()
        {

            List<Person> sortedFamily = Member.OrderBy(m => m.Age).ToList();

            return sortedFamily[0];
        }

    }
}
