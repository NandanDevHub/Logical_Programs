namespace BeginnerPrograms;
class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("----------------------------------- \n");
            Console.WriteLine("Please Choose Option Number between 0 to 70 : \n");
            Console.WriteLine("1 - Hello World");
            Console.WriteLine("2 - Sum of Two Numbers");
            Console.WriteLine("3 - Number is Even or Odd");
            Console.WriteLine("0 - Exit \n");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    var helloWorld = new HelloWorld();
                    helloWorld.HelloWorldText();
                    break;
                case "2":
                    var calculateSum = new SumTwoNums();
                    calculateSum.CalculateSum();
                    break;
                case "3":
                    var evenOrOdd = new EvenOrOdd();
                    evenOrOdd.NumberEvenOrOdd();
                    break;
                default:
                    Console.WriteLine("Exiting the Program....");
                    return;
            }
        }
    }
}