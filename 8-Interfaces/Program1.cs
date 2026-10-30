public class Program1 : IStartable, ILoggable
{
    // public void Run()
    // {
    //     Console.WriteLine("Now running program 1");
    // }

    public void Start()
    {
        Console.WriteLine("Now running program 1");
    }

    public void LogStatus()
    {
        Console.WriteLine("Program 1 status: Active and logged.");
    }
}