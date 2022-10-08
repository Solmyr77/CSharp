class Person
{
    public string name;
    public int birth;

    public Person(string aname, int abirth)
    {
        name = aname;
        birth = abirth;
    }
}

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Add meg egy ember nevét: ");
            string curr_name = Convert.ToString(Console.ReadLine());

            Console.Write($"Add meg {curr_name} születési évét: ");
            int curr_birth = Convert.ToInt32(Console.ReadLine());

            people[i] = new Person(curr_name, curr_birth);
        }

        Person oldest = people[0];

        foreach (Person curr_person in people)
        {
            if (curr_person.birth < oldest.birth)
            {
                oldest = curr_person;
            }
        }

        using (StreamWriter writext = new StreamWriter("legidosebb.txt"))
        {
            writext.WriteLine($"{oldest.name} a legidősebb.");
        }
    }
}