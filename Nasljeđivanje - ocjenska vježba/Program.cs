using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni(100);
            Negativni y = new Negativni(-100);
            Decimalni z = new Decimalni(100.45);

            Console.WriteLine(x.ApsVrijednost());
            Console.WriteLine(y.ApsVrijednost());
            Console.WriteLine(z.ApsVrijednost());

            Console.ReadKey();
        }
    }
    class Brojevi
    {
        public double broj;

        public double Broj { get => broj; set => broj = value; }

        public virtual double ApsVrijednost()
        {
            return 0;
        }
        public Brojevi()
        {

        }
        public Brojevi(double broj)
        {
            this.broj = broj;
        }
    }
    class Cijeli : Brojevi
    {
        public Cijeli(double broj) : base(broj)
        {

        }
        public override double ApsVrijednost()
        {
            return this.broj;
        }
    }
    class Decimalni : Brojevi
    {
        public Decimalni(double broj) : base(broj)
        {

        }
        public override double ApsVrijednost()
        {
            return this.broj;
        }
    }
    class Pozitivni : Cijeli
    {
        public Pozitivni(double broj) : base(broj)
        {

        }
        public override double ApsVrijednost()
        {
            return this.broj;
        }
    }
    class Negativni : Cijeli
    {
        public Negativni(double broj) : base(broj)
        {

        }
        public override double ApsVrijednost()
        {
            return this.broj * (-1);
        }
    }
}