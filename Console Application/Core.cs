using System;

namespace MyConverter.ConsoleApp
{
    // Basic operations and logic class.
    public class Core   
    {
        public void ProgramLoop()
        {
            WelcomeScreen();
            bool loopStatus = true;
            while (loopStatus)
            {
                string input = GetInput();
                loopStatus = InputProcessing(input);
            }
        }

        public void WelcomeScreen()
        {
            Variables variables = new Variables();
            Console.WriteLine($"MyConverter - v. {variables.appVersion}; See list of commands by typing «list».");
            Console.WriteLine("View source code on Github: https://github.com/Sixaeity/MyConverter.\n");
        }

        public string GetInput()
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            return input;
        }

        public bool InputProcessing(string input)
        {
            switch(input)
            {
                case "quit":
                case "q":
                    return false;

                case "list":
                case "ls":

                    return true;

                case "length":
                    Length length = new Length();
                    length.Run();
                    return true;

                default:
                    Console.WriteLine("\n\tUnknown command. See list of commands by typing «list».\n");
                    return true;
            }
        }
    }
}