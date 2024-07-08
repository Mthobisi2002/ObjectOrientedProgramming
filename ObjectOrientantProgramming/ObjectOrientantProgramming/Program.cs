using ObjectOrientantProgramming.Encapsulation;
using ObjectOrientantProgramming.Inheritance;
using ObjectOrientantProgramming.TypesOfConstructors;

internal class Pogram
{
    static void Main(string[] args)
    {
        //Encapusulation
        Encapsulation encapsulation = new Encapsulation("Mthobisi", "Khanyile", 22);
        
        Console.WriteLine("Encapsulation:");
        Console.WriteLine($"My name is {encapsulation.Name}, my surname is {encapsulation.Surname}, and i am {encapsulation.Age} years old...");

        //Second(Paramiterized Constructor
        Second second = new Second("Software Developer", "LexisNexis", "Junior", 1);

        Console.WriteLine("Parameterized Constructor:");
        Console.WriteLine($"{second.Company} has a {second.Position} {second.Job} open that needs {second.Experience} years of experience");

        //Accessing and Modifying values
        second.Company = "Nologo Studios";
        second.Job = "Back-end developer";
        second.Position = "Intern";
        second.Experience = 0;

        Console.WriteLine("Modified values:");
        Console.WriteLine($"{second.Company} has a {second.Position} {second.Job} open that needs {second.Experience} years of experience");

        //Accessing Private Constructor(Third)
        Third third = Third.CreateThird("Software Engineer");

        Console.WriteLine("Private Constructor:");
        Console.WriteLine($"Applying for a {third.Job} position");

        //Static Constructor(Fourth)
        Console.WriteLine("Static Constructor:");
        Fourth fourth1 = new Fourth();
        Console.WriteLine("Trying to display Static Constructor again:");
        Fourth fourth2 = new Fourth();


        //Copy Constructor
        Fifth fifth = new Fifth("LexisNexis");
        Fifth fifthcopy = new Fifth(fifth);

        Console.WriteLine("Copy Constructor:");
        Console.WriteLine($"Compnay name is:{fifthcopy.Company}");

        //Inheritance
        FictionBook fictionbook = new FictionBook("OOP", "C#", 200, "Inheritance", "Programming");
        fictionbook.DisplayInfo();

        Console.ReadKey();
    }
}
