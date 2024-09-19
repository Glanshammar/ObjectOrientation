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
            // This line should not be reached.
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
            // This line should not be reached.
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Expected error: {ex.Message}");
        }
    }
}

public class AnimalTest
{
    public static void Run()
    {
        List<Animal> animals = new List<Animal>
        {
            new Horse("Thunder", 450, 7, 30),
            new Dog("Buddy", 25, 5, "Labrador"),
            new Hedgehog("Spike", 0.5, 2, 5000),
            new Worm("Wiggles", 0.01, 1, false),
            new Bird("Tweety", 0.1, 1, 15),
            new Wolf("Luna", 40, 4, "Alpha"),
            new Pelican("Pete", 15, 10, 250, 10),
            new Flamingo("Pinky", 4, 6, 150, "Pink"),
            new Swan("Grace", 12, 8, 200, true),
            new Wolfman("Lycaon", 80, 30, "Lone Wolf")
        };

        Console.WriteLine("Animals in the list:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"Type: {animal.GetType().Name}, Name: {animal.Name}");
            animal.DoSound();
            if (animal is IPerson person)
            {
                person.Talk();
            }
            Console.WriteLine();
        }

        List<Dog> dogs = new List<Dog>();
        dogs.Add(new Dog("Rex", 30, 6, "German Shepherd"));

        /*
            F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            dogs.Add(new Horse("Blaze", 500, 8, 35)); == Compilation error
            A: Det fungerar inte eftersom listan är bestämd en viss typ (till en Dog) och en Horse är inte en Dog.

            F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            A: Listan måste vara av typen List<Animal> för att kunna lagra alla djurklasser tillsammans.
        */
        
        Console.WriteLine("\nStats for all animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Stats());
        }

        /*
            F: Förklara vad det är som händer.
            A: När vi anropar Stats() metoden på varje djur i listan, används den överlagrade versionen 
            av metoden för varje specifik djurklass. Detta är ett exempel på polymorfism.
        */

        Console.WriteLine("\nStats for dogs only:");
        foreach (var animal in animals)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.Stats());
            }
        }

        // 16. Kommer du åt den metoden från Animals listan?
        // 17. F: Varför inte?
        // A: Nej, vi kommer inte åt WagTail() metoden direkt från Animals listan eftersom listan är av typen Animal, 
        // och Animal-klassen inte har någon WagTail() metod.

        // 18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals
        Console.WriteLine("\nDog-specific method:");
        foreach (var animal in animals)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.WagTail());
            }
        }
    }
}