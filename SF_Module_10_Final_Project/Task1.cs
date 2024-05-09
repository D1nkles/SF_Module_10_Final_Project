using Task2;

namespace Task1
{
    class Calculator : ISum
    {
        ILogger Logger { get; }
        int Num1 { get; set; }
        int Num2 { get; set; }
        public Calculator(ILogger logger)
        {
            Logger = logger;

            while (true)
            {
                try
                {
                    Initialize();
                }
                catch (FormatException)
                {
                    Logger.Error("\nОшибка: Вы ввели не число, либо число в неверном формате!!!");
                    Console.WriteLine("Нажмите любую клавишу, чтобы попробовать снова...\n");
                    Console.ReadKey();
                }
            }
        }

        public void Initialize() 
        {
            Console.Write("Введите первое целое число: ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            Num2 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Нажмите любую клавишу, чтобы сложить введенные числа...\n");
            Console.ReadKey();
            Logger.Event("Рассчет начат!\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Сумма чисел равна {Sum(Num1, Num2)}\n");
            Logger.Event("Рассчет окончен!\n");
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}