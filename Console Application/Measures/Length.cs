using System;

namespace MyConverter.ConsoleApp
{
    public class Length
    {
        public void Run()
        {
            Core core =new Core();
            Console.Write("\nEnter initial value:");
            double initValue = Double.Parse(core.GetInput());
            Console.Write("\nEnter initial measure:");
            string initMeasure = core.GetInput();
            Console.Write("\nEnter final measure:");
            string finalMeasure = core.GetInput();

            if (initMeasure == finalMeasure)
                throw new Exception("");

            double finalValue = initValue;

            switch (initMeasure)
            {
                case "kilometre":
                case "kilometres":
                case "km":
                    switch (finalMeasure)
                    {
                        case "metre":
                        case "metres":
                        case "m":
                            finalValue *= 1000;
                        break;

                        case "centimetre":
                        case "centimetres":
                        case "cm":
                            finalValue *= 100000;
                        break;

                        case "millimetre":
                        case "millimetres":
                        case "mm":
                            finalValue *= 1000000;
                        break;

                        default:
                            Console.WriteLine("\nUnknown measure.\n");
                            break;
                    }
                    break;

                case "metre":
                case "metres":
                case "m":
                    switch (finalMeasure)
                    {
                        case "kilometre":
                        case "kilometres":
                        case "km":
                            finalValue *= 0.001;
                        break;

                        case "centimetre":
                        case "centimetres":
                        case "cm":
                            finalValue *= 100;
                        break;

                        case "millimetre":
                        case "millimetres":
                        case "mm":
                            finalValue *= 1000;
                        break;

                        default:
                            Console.WriteLine("\nUnknown measure.\n");
                            break;
                    }
                    break;

                case "centimetre":
                case "centimetres":
                case "cm":
                    switch (finalMeasure)
                    {
                        case "kilometre":
                        case "kilometres":
                        case "km":
                            finalValue *= 0.0001;
                        break;

                        case "metre":
                        case "metres":
                        case "m":
                            finalValue *= 0.01;
                        break;

                        case "millimetre":
                        case "millimetres":
                        case "mm":
                            finalValue *= 10;
                        break;

                        default:
                            Console.WriteLine("\nUnknown measure.\n");
                            break;
                    }
                    break;

                case "millimetre":
                case "millimetres":
                case "mm":
                    switch (finalMeasure)
                    {
                        case "kilometre":
                        case "kilometres":
                        case "km":
                            finalValue *= 0.000001;
                        break;

                        case "metre":
                        case "metres":
                        case "m":
                            finalValue *= 0.001;
                        break;

                        case "centimetre":
                        case "centimetres":
                        case "cm":
                            finalValue *= 0.1;
                        break;

                        default:
                            Console.WriteLine("\nUnknown measure.\n");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("\nUnknown measure.\n");
                    break;
            }

            Console.WriteLine("\n{0} {1} equals {2} {3}.\n", initValue, initMeasure,finalValue, finalMeasure);
        }
    }
}