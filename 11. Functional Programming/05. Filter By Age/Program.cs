using System;
using System.Diagnostics;
using System.Security;

int n = int.Parse(Console.ReadLine());
Dictionary<string, int> people = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine().Split(", ").ToList();
    people.Add(input[0], int.Parse(input[1]));
}

string condition = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Func<Dictionary<string, int>, string, int, Dictionary<string, int>> ageFilter = (people, condition,age ) =>
{
    Dictionary<string, int> filteredPeople = new Dictionary<string, int>();
    if(condition == "older")
    {
        foreach (var person in people)
        {
            if(person.Value >= age)
            {
                filteredPeople.Add(person.Key, person.Value);
            }
        }
    }
    else
    {
        foreach (var person in people)
        {
            if (person.Value < age)
            {
                filteredPeople.Add(person.Key, person.Value);
            }
        }
    }
    return filteredPeople;
};

people = new Dictionary<string, int>(ageFilter(people, condition,age));

string orderCmd = Console.ReadLine();

Action<Dictionary<string,int>> printByCmd = (people) =>
{
 
    if (orderCmd == "name age")
    {
        foreach (var person in people)
        {
        Console.WriteLine($"{person.Key} - {person.Value}");
        }
    }
    else if (orderCmd == "name")
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Key}");
        }
    }
    else
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Value}");
        }
    }
};

printByCmd(people);

