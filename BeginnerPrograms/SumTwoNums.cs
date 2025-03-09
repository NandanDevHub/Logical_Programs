namespace BeginnerPrograms;

public class SumTwoNums
{
    public void CalculateSum()
    {
        Console.Write("Please enter the first number ");
        var a = int.Parse(Console.ReadLine());
        
        Console.Write("Please enter the second number ");
        var b = int.Parse(Console.ReadLine());

        var c = a + b;
        
        Console.WriteLine("The Sum of " +  a  + " and " + b + "is " + c);
    }
}