namespace ObjectOrientation;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be greater than 0.");
            age = value;
        }
    }

    public string FName
    {
        get { return fName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                throw new ArgumentException("First name must be between 2 and 10 characters.");
            fName = value;
        }
    }

    public string LName
    {
        get { return lName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                throw new ArgumentException("Last name must be between 3 and 15 characters.");
            lName = value;
        }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }
}