
using NMLaba1;

internal class Program
{
    private static void Main(string[] args)
    {
        Relaxation relaxation;
        Newton newton;
        SimpleIteration simpleIteration;
        Console.WriteLine("Relaxation: ");
        relaxation = new Relaxation();
        Console.WriteLine("\n\nNewton: ");
        newton = new Newton();
        Console.WriteLine("\n\nSimpleIteration: ");
        simpleIteration = new SimpleIteration();
    }
}