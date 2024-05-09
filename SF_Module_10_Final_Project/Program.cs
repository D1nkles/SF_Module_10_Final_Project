using Task1;
using Task2;

namespace SF_Module_10_Final_Project
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            new Calculator(Logger);
        }
    }
}
