public class ExerciseRunner
{
    public void Execute()
    {
        Program1 program1 = new Program1();
        Program2 program2 = new Program2();

        // program1.Run();
        // program2.Go();

        List<IStartable> programs = new List<IStartable> { program1, program2 };
        foreach (IStartable program in programs)
        {
            program.Start();
        }

        program1.LogStatus();

        Console.WriteLine("\n--- Extra Task ---");
        DualRunner dualRunner = new DualRunner();

        ((IVoidRunner)dualRunner).Run();
        int number = ((IIntRunner)dualRunner).Run();
        Console.WriteLine($"Returned value from int Run(): {number}");
    }
}