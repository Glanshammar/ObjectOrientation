namespace ObjectOrientation;

public class PersonTest
{
    public static void Run()
    {
        Console.WriteLine("Person Handling Demonstration:");
        PersonHandler handler = new PersonHandler();

        TestValidPersonCreation(handler);
        TestInvalidNameInput(handler);
        TestInvalidAgeInput(handler);

        Console.WriteLine();
    }

    private static void TestValidPersonCreation(PersonHandler handler)
    {
        try
        {
            Person person1 = handler.CreatePerson(25, "John", "Doe", 180.5, 75.0);
            Console.WriteLine($"Created person: {handler.GetFullName(person1)}, Age: {person1.Age}");

            handler.SetAge(person1, 26);
            Console.WriteLine($"Updated age: {person1.Age}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void TestInvalidNameInput(PersonHandler handler)
    {
        try
        {
            Person person = handler.CreatePerson(30, "A", "Smith");
            Console.WriteLine("This line should not be reached.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Expected error: {ex.Message}");
        }
    }

    private static void TestInvalidAgeInput(PersonHandler handler)
    {
        try
        {
            Person person = handler.CreatePerson(-5, "Jane", "Doe", 165.0, 60.0);
            Console.WriteLine("This line should not be reached.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Expected error: {ex.Message}");
        }
    }
}

