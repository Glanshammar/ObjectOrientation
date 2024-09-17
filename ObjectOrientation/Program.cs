namespace ObjectOrientation;

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation
        PersonTest.Run();

        // Polymorphism
        List<UserError> errors = new List<UserError>
        {
            new NumericInputError(),
            new TextInputError(),
            new DateFormatError(),
            new EmailFormatError(),
            new PasswordStrengthError()
        };

        foreach (var error in errors)
        {
            Console.WriteLine(error.UEMessage());
        }
    }
}