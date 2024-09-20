namespace ObjectOrientation;

public class PersonTest
{
    public static void Run()
    {
        /*
        Person person1 = new Person();
        person1.Age = 27;
        person1.FName = "Andreas";
        person1.LName = "Johansson";
        person1.Height = 165;
        person1.Weight = 78;
        */
        
        Console.WriteLine("Person Handling:");
        PersonHandler handler = new PersonHandler();


        try
        {
            Person person = handler.CreatePerson("Andreas", "Johansson",27, 165, 78.0);
            Console.WriteLine($"Created person: {handler.GetFullName(person)}" +
                              $"\nAge: {person.Age}" +
                              $"\nHeight: {person.Height}" +
                              $"\nWeight: {person.Weight}"
                              );

            Console.WriteLine();
            handler.SayHello(person);
            
            handler.SetAge(person, 69);
            handler.SetHeight(person, 187);
            handler.SetWeight(person, 93);
            Console.WriteLine($"Updated information for {handler.GetFullName(person)}:" +
                              $"\nAge: {person.Age}" +
                              $"\nHeight: {person.Height}" +
                              $"\nWeight: {person.Weight}"
                              );
            
            
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:  {ex.Message}");
        }

        Console.WriteLine();
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