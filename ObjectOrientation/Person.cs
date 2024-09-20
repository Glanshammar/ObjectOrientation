namespace ObjectOrientation;

public class Person
{
    private int _age;
    private string _fName = string.Empty;
    private string _lName = string.Empty;
    private double _height;
    private double _weight;
    
    
    public int Age
    {
        get => _age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be greater than 0.");
            _age = value;
        }
    }

    public string FName
    {
        get => _fName;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                throw new ArgumentException("First name must be between 2 and 10 characters.");
            _fName = value;
        }
    }

    public string LName
    {
        get => _lName;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                throw new ArgumentException("Last name must be between 3 and 15 characters.");
            _lName = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than 0.");
            _height = value;
        }
    }

    public double Weight
    {
        get => _weight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Weight must be greater than 0.");
            _weight = value;
        }
    }
}