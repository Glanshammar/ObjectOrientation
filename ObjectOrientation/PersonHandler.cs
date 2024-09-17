namespace ObjectOrientation;

public class PersonHandler
{
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }

    public Person CreatePerson(int age, string fname, string lname, double height = 0, double weight = 0)
    {
        Person person = new Person();
        person.Age = age;
        person.FName = fname;
        person.LName = lname;
        person.Height = height;
        person.Weight = weight;
        return person;
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
}