namespace BeginnerPrograms;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Please Choose Option in Small Case:\n");
       foreach (var item in Constants.ProgramList)
       {
           Console.WriteLine(item);
       }

       var userInput = Console.ReadLine();
       switch (userInput)
       {
           case "helloworld":
               Console.WriteLine();
               var helloWorld = new HelloWorld();
               break;
           case "sumtwonum":
               Console.WriteLine();
                var newsum = new SumTwoNums();
               break;
           case "evenorodd":
               Console.WriteLine();
               var evenodd = new EvenOrOdd();
               break;
           default:
               Console.WriteLine("Invalid Option Entered");
               break;
       }
    }
}