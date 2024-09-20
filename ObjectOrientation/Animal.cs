namespace ObjectOrientation;

public interface IPerson
{
    void Talk();
}

// Abstract base class Animal
public abstract class Animal(string name, double weight, int age)
{
    public string Name { get; protected set; } = name;
    public double Weight { get; protected set; } = weight;
    public int Age { get; protected set; } = age;

    public abstract void DoSound();

    public virtual string Stats()
    {
        return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
    }
}

public class Horse(string name, double weight, int age, int maneLength) : Animal(name, weight, age)
{
    private int ManeLength { get; } = maneLength;

    public override void DoSound() => Console.WriteLine("Neigh!");

    public override string Stats() => base.Stats() + $", Mane Length: {ManeLength}cm";
}

public class Dog(string name, double weight, int age, string breed) : Animal(name, weight, age)
{
    private string Breed { get; } = breed;

    public override void DoSound() => Console.WriteLine("Woof!");

    public override string Stats() => base.Stats() + $", Breed: {Breed}";

    public string WagTail() => $"{Name} is wagging its tail!";
}

public class Hedgehog(string name, double weight, int age, int nrOfSpikes) : Animal(name, weight, age)
{
    private int SpikeAmount { get; } = nrOfSpikes;

    public override void DoSound() => Console.WriteLine("Snuffle!");

    public override string Stats() => base.Stats() + $", Number of Spikes: {SpikeAmount}";
}

public class Worm(string name, double weight, int age, bool isPoisonous) : Animal(name, weight, age)
{
    private bool IsPoisonous { get; } = isPoisonous;

    public override void DoSound() => Console.WriteLine("...");

    public override string Stats() => base.Stats() + $", Is Poisonous: {IsPoisonous}";
}

public class Bird(string name, double weight, int age, double wingSpan) : Animal(name, weight, age)
{
    private double WingSpan { get; } = wingSpan;

    public override void DoSound() => Console.WriteLine("Tweet!");

    public override string Stats() => base.Stats() + $", Wing Span: {WingSpan}cm";
}

public class Wolf(string name, double weight, int age, string packRole) : Animal(name, weight, age)
{
    private string PackRole { get; } = packRole;

    public override void DoSound() => Console.WriteLine("Howl!");

    public override string Stats() => base.Stats() + $", Pack Role: {PackRole}";
}

public class Pelican(string name, double weight, int age, double wingSpan, double beakVolume) 
    : Bird(name, weight, age, wingSpan)
{
    private double BeakVolume { get; } = beakVolume;

    public override string Stats() => base.Stats() + $", Beak Volume: {BeakVolume}L";
}

public class Flamingo(string name, double weight, int age, double wingSpan, string legColor) 
    : Bird(name, weight, age, wingSpan)
{
    private string LegColor { get; } = legColor;

    public override string Stats() => base.Stats() + $", Leg Color: {LegColor}";
}

public class Swan(string name, double weight, int age, double wingSpan, bool isRoyal) 
    : Bird(name, weight, age, wingSpan)
{
    private bool IsRoyal { get; } = isRoyal;

    public override string Stats() => base.Stats() + $", Is Royal: {IsRoyal}";
}

public class Wolfman(string name, double weight, int age, string packRole) 
    : Wolf(name, weight, age, packRole), IPerson
{
    public void Talk() => Console.WriteLine("I am a Wolfman!");
}


/*
F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
attribut, i vilken klass bör vi lägga det?

A: Vi bör lägga det nya attributet i klassen Bird. Eftersom Bird är basklassen för 
alla fåglar (Pelican, Flamingo, Swan), kommer alla fågelklasser att ärva detta 
nya attribut automatiskt.
____________________________________________________________________________________

F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?

A: Om alla djur behöver det nya attributet, bör vi lägga det i den abstrakta 
basklassen Animal. På detta sätt kommer alla djurklasser som ärver från Animal 
(inklusive Bird och dess subklasser) att få tillgång till det nya attributet.
*/