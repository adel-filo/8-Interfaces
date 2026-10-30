public class DualRunner : IVoidRunner, IIntRunner
{
    void IVoidRunner.Run()
    {
        Console.WriteLine("Executing void Run() method.");
    }

    int IIntRunner.Run()
    {
        Console.WriteLine("Executing int Run() method.");
        return 7;
    }
}