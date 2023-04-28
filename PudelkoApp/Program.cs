using PudelkoLibrary;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Pudelko p1 = new Pudelko(2.1, 1, 3.05);
        Pudelko p2 = new Pudelko(50, 50, 50, unit: UnitOfMeasure.centimeter);
        Pudelko p3 = new Pudelko(4,9,5);

        


        Console.WriteLine();
        List<Pudelko> list = new List<Pudelko>();
        list.Add(p1);
        list.Add(p2);
        list.Add(p3);
        foreach (var x in list)
        {
            Console.WriteLine(x.ToString(format:"cm",formatProvider:null));
        }

        //SORTOWANIE
        var q = list.OrderBy(Pudelko => Pudelko.Objetosc).ThenBy(Pudelko => Pudelko.Pole).ThenBy(Pudelko => Pudelko.A + Pudelko.B + Pudelko.C);
        Console.WriteLine();
        foreach (var x in q)
        {
            Console.WriteLine(x.ToString(format: "cm", formatProvider: null));
        }
    }
}
