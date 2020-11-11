using System;

namespace MyConverter.ConsoleApp
{
    public class Length
    {
        // Default measure of length is metres (m).

        public void Cycle()
        {
            Console.Write("\nEnter a value: ");
            double value = Double.Parse(Console.ReadLine());
            Console.Write("Enter a value measure: ");
            string measure = Console.ReadLine();
            Console.Write("Enter a new measure: ");
            string newMeasure = Console.ReadLine();

            double newValue = Proccesing(value, measure, newMeasure);

            Console.WriteLine("\n{0} {1} equals to {2} {3}.\n", value, measure, newValue, newMeasure);
        }

        public double Proccesing(double value, string measure, string newMeasure)
        {
            switch (newMeasure)
            {
                case "km":
                    return ToKilometres(value, measure);

                case "m":
                    return ToMetres(value, measure);
                
                case "cm":
                    return ToCentimetres(value, measure);
                
                case "mm":
                    return ToMillimetres(value, measure);

                default:
                    throw new Exception("Unknown measure of new length.");
            }
        }

        public double ToKilometres(double value, string measure)
        {
            double inKilometres = 1;
            double inMetres = 0.001;
            double inCentimetres = 0.00001;
            double inMillimetres = 0.000001;
            return Convert(value, measure, inKilometres, inMetres, inCentimetres, inMillimetres);
        }

        public double ToMetres(double value, string measure)
        {
            double inKilometres = 1000;
            double inMetres = 1;
            double inCentimetres = 0.01;
            double inMillimetres = 0.001;
            return Convert(value, measure, inKilometres, inMetres, inCentimetres, inMillimetres);
        }

        public double ToCentimetres(double value, string measure)
        {
            double inKilometres = 100000;
            double inMetres = 100;
            double inCentimetres = 1;
            double inMillimetres = 0.1;
            return Convert(value, measure, inKilometres, inMetres, inCentimetres, inMillimetres);
        }

        public double ToMillimetres(double value, string measure)
        {
            double inKilometres = 1000000;
            double inMetres = 1000;
            double inCentimetres = 10;
            double inMillimetres = 1;
            return Convert(value, measure, inKilometres, inMetres, inCentimetres, inMillimetres);
        }

        public double Convert(double value, string measure, double inKilometres, double inMetres, double inCentimetres, double inMillimetres)
        {
            switch (measure)
            {
                case "km":
                    return (value * inKilometres);
                
                case "m":
                    return (value * inMetres);
                
                case "cm":
                    return (value * inCentimetres);
                
                case "mm":
                    return (value * inMillimetres);

                default:
                    throw new Exception("Unknown measure of value length.");
            }
        }
    }
}