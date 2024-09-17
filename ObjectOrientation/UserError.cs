namespace ObjectOrientation;

public abstract class UserError
{
    public abstract string UEMessage();
}

public class NumericInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}

public class TextInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}

// Three additional custom error classes
public class DateFormatError : UserError
{
    public override string UEMessage()
    {
        return "You entered an invalid date format. Please use YYYY-MM-DD.";
    }
}

public class EmailFormatError : UserError
{
    public override string UEMessage()
    {
        return "The email address you entered is not valid. Please check and try again.";
    }
}

public class PasswordStrengthError : UserError
{
    public override string UEMessage()
    {
        return "Your password is too weak. It must contain at least 8 characters, including uppercase, lowercase, numbers, and special characters.";
    }
}