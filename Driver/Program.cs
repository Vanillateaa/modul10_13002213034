using MatematikaLibraries;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FPB dari 60 & 45");
        Console.WriteLine(Matematika.FPB(60, 45));
        Console.WriteLine("KPK dari 12 & 8");
        Console.WriteLine(Matematika.KPK(12, 8));
        Console.WriteLine("turunan dari 1, 4, -12, 9");
        Console.WriteLine(Matematika.Turunan(new int[] { 1, 4, -12, 9 }));
        Console.WriteLine("integral dari 4, 6, -12, 9");
        Console.WriteLine(Matematika.Integral(new int[] { 4, 6, -12, 9 }));

    }
}