namespace BeginnerPrograms;

public class EvenOrOdd
{
    public void NumberEvenOrOdd()
    {
        Console.WriteLine("Please enter any number ");
        var x = int.Parse(Console.ReadLine());

        Console.WriteLine(x == 0 ? "Number is Even" : "Number is Odd");

        Console.ReadKey();
    }
}
 
 