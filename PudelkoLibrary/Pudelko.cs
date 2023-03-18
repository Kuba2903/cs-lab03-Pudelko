using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace PudelkoLibrary
{
    public class Pudelko : IFormattable, IEquatable<Pudelko>, IEnumerable
    {



        private double a; private double b; private double c;
        private double centia; private double centib; private double centic;
        private double milia; private double milib; private double milic;
        public double A
        {
            get
            {
                return Math.Round(a, 3);
            }
            set { a = value; }
        }
        public double B
        {
            get
            {
                return Math.Round(b, 3);
            }
            set { b = value; }
        }
        public double C
        {
            get
            {
                return Math.Round(c, 3);
            }
            set { c = value; }
        }

        public double centiA
        {
            get
            {
                return Math.Round(centia, 1);
            }
            set { centia = value; }
        }
        public double centiB
        {
            get
            {
                return Math.Round(centib, 1);
            }
            set { centib = value; }
        }
        public double centiC
        {
            get
            {
                return Math.Round(centic, 1);
            }
            set { centic = value; }
        }

        public double miliA
        {
            get
            {
                return milia;
            }
            set { milia = value; }
        }
        public double miliB
        {
            get
            {
                return milib;
            }
            set { milib = value; }
        }
        public double miliC
        {
            get
            {
                return milic;
            }
            set { milic = value; }
        }

        private double objetosc { get; set; }
        public double Objetosc
        {
            get
            {
                double objetosc = A * B * C;
                return Math.Round(objetosc, 9);
            }
            set { objetosc = value; }
        }

        public double Pole
        {
            get
            {
                double pole = (2 * A * B) + (2 * A * C) + (2 * B * C);
                return Math.Round(pole, 6);
            }
        }

        public Pudelko(double a = 0.1, double b = 0.1, double c = 0.1, UnitOfMeasure unit = UnitOfMeasure.meter)
        {

            double miliA = 0;
            double miliB = 0;
            double miliC = 0;

            double centiA = 0;
            double centiB = 0;
            double centiC = 0;

            double meterA = 0;
            double meterB = 0;
            double meterC = 0;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }



            if (unit == UnitOfMeasure.meter)
            {

                if (a > 10 || b > 10 || c > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }

                miliA = a * 1000;
                miliB = b * 1000;
                miliC = c * 1000;

                centiA = a * 100;
                centiB = b * 100;
                centiC = c * 100;

                this.centia = centiA;
                this.centib = centiB;
                this.centic = centiC;

                this.milia = miliA;
                this.milib = miliB;
                this.milic = miliC;

                this.a = a;
                this.b = b;
                this.c = c;
            }
            else if (unit == UnitOfMeasure.centimeter)
            {
                if (a > 1000 || b > 1000 || c > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }


                miliA = a * 10;
                miliB = b * 10;
                miliC = c * 10;

                meterA = a * 0.01;
                meterB = b * 0.01;
                meterC = c * 0.01;

                this.milia = miliA;
                this.milib = miliB;
                this.milic = miliC;

                this.a = meterA;
                this.b = meterB;
                this.c = meterC;

                this.centiA = a;
                this.centiB = b;
                this.centiC = c;

            }
            else if (unit == UnitOfMeasure.milimeter)
            {
                if (a > 10000 || b > 10000 || c > 10000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                centiA = a / 10;
                centiB = b / 10;
                centiC = c / 10;

                meterA = a / 1000;
                meterB = b / 1000;
                meterC = c / 1000;

                this.centia = centiA;
                this.centib = centiB;
                this.centic = centiC;

                this.a = meterA;
                this.b = meterB;
                this.c = meterC;

                this.miliA = a;
                this.miliB = b;
                this.miliC = c;
            }

        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {

            if (format == "m")
            {
                return $"{A.ToString("0.000")} m x {B.ToString("0.000")} m x {C.ToString("0.000")} m";
            }
            else if (format == "cm")
            {
                return $"{centiA.ToString("0.0")} cm x {centiB.ToString("0.0")} cm x {centiC.ToString("0.0")} cm";
            }
            else if (format == "mm")
            {
                return $"{miliA} mm x {miliB} mm x {miliC} mm";
            }
            else
            {
                throw new FormatException();
            }
        }



        public bool Equals(Pudelko? other)
        {
            if (Objetosc == other.Objetosc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pudelko)
            {
                return Equals((Pudelko)obj);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode() => (A, B, C).GetHashCode();

        public IEnumerator GetEnumerator()
        {
            foreach (var x in dlugosci)
            {
                Console.WriteLine(x);
            }
            return dlugosci.GetEnumerator();
        }

        public static bool operator ==(Pudelko p1, Pudelko p2) => Equals(p1, p2);
        public static bool operator !=(Pudelko p1, Pudelko p2) => !(p1 == p2);

        public static Pudelko operator +(Pudelko p1, Pudelko p2)
        {
            Pudelko p3 = new Pudelko();
            p3.A = p1.A + p2.A;
            p3.B = p1.B + p2.B;
            p3.C = p1.C + p2.C;
            //p3.Objetosc = p1.Objetosc + p2.Objetosc;
            return p3;
        }

        public static string Parse(Pudelko p,UnitOfMeasure unit)
        {
            if(unit == UnitOfMeasure.meter)
            {
                return $"{p.A.ToString("0.000")} m x {p.B.ToString("0.000")} m x {p.C.ToString("0.000")} m";
            }else if(unit == UnitOfMeasure.centimeter)
            {
                return $"{p.centiA.ToString("0.0")} cm x {p.centiB.ToString("0.0")} cm x {p.centiC.ToString("0.0")} cm";
            }else if(unit == UnitOfMeasure.milimeter)
            {
                return $"{p.miliA} mm x {p.miliB} mm x {p.miliC} mm";
            }
            else
            {
                throw new FormatException();
            }

        }


        public double[] dlugosci = new double[3];

        public double[] Dlugosci
        {
            get
            {
                dlugosci[0] = A;
                dlugosci[1] = B;
                dlugosci[2] = C;
                return dlugosci;
            }
        }

        ValueTuple<int, int> Value = new ValueTuple<int, int>();




    }
}