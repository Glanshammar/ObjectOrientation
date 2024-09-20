namespace ObjectOrientation;

public class PersonHandler
{

    public Person CreatePerson(string fname, string lname, int age, double height = 0, double weight = 0)
    {
        Person person = new Person();
        person.FName = fname;
        person.LName = lname;
        person.Age = age;
        person.Height = height;
        person.Weight = weight;
        return person;
    }

    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }
    
    // Additional methods for handling Person objects
    public void SetName(Person pers, string fname, string lname)
    {
        pers.FName = fname;
        pers.LName = lname;
    }

    public void SetHeight(Person pers, double height)
    {
        pers.Height = height;
    }

    public void SetWeight(Person pers, double weight)
    {
        pers.Weight = weight;
    }

    public string GetFullName(Person pers)
    {
        return $"{pers.FName} {pers.LName}";
    }

    public void SayHello(Person pers)
    {
        Console.WriteLine($"Hello, my name is {GetFullName(pers)}!");
    }
}