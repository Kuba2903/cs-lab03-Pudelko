using PudelkoLibrary;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Pudelko p1 = new Pudelko(2.1, 1, 3.05);
        Pudelko p2 = new Pudelko(50, 50, 50, unit: UnitOfMeasure.centimeter);
        Pudelko p3 = new Pudelko(2100, 1000, 3050, unit: UnitOfMeasure.milimeter);


        //Pudelko p3 = p1 + p2;

        var p = new Pudelko(1, 2.1, 3.231);
        /*var tab = new[] { p.A, p.B, p.C };
        int i = 0;
        foreach (double x in p)
        {
            Console.WriteLine(x + tab[i]);
            i++;
        }*/
        p.GetEnumerator();
    }
}
