using PudelkoLibrary;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Pudelko p1 = new Pudelko(2.1, 1, 3.05);
        Pudelko p2 = new Pudelko(100, 50, 50, unit: UnitOfMeasure.centimeter);
        Pudelko p3 = new Pudelko(2100, 1000, 3050, unit: UnitOfMeasure.milimeter);

        Console.WriteLine(Pudelko.Parse(p1,UnitOfMeasure.milimeter));

        var p = new Pudelko(2.5, 9.321);
        //Pudelko p3 = p1 + p2;

        Console.WriteLine(p1.Equals(p3));
        Console.WriteLine(p.ToString(format: "m", formatProvider: null));
        Console.WriteLine(p3.ToString(format: "mm", formatProvider: null));
    }
}
