namespace MendeleevClapeyronEquation;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter: mass, molar mass");
        decimal m = Convert.ToDecimal(Console.ReadLine());
        decimal M = Convert.ToDecimal(Console.ReadLine());
        MendeleevClapeyronEquationUsing mce = new MendeleevClapeyronEquationUsing(m, M);
        Console.WriteLine("Enter: pressure, volume");
        decimal d = Convert.ToDecimal(Console.ReadLine());
        decimal v = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"temperature: {Math.Round(mce.CalculateTemperature(d, v), 2)}K\n" +
                          $"Number of molecules: {Math.Round(mce.N, 2)} * 10^23");
    }
}
