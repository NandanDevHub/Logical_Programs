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
               var helloWorld = new HelloWorld();
               break;
       }
    }
}