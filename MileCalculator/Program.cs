// See https://aka.ms/new-console-template for more information
using MileCalculator;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string distance = "";
        Console.WriteLine("Enter from zip code!");
        string fromZip = Console.ReadLine();
        Console.WriteLine("Enter destination code!");
        string toZip = Console.ReadLine();
        ZipDistance obj = new ZipDistance();
        distance= await obj.GetDistance(fromZip, toZip);
        Console.WriteLine("Distance -"+ distance);
        Console.ReadLine();
    }
}