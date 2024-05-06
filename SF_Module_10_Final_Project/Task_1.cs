namespace Task_1
{
    interface ISum
    {
        int Sum(int num1, int num2);
    }

    class Calculator : ISum
    {
        int Num1 { get; set; }
        int Num2 { get; set; }
        public Calculator()
        {
            while (true)
            {
                try
                {
                    Initialize();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Вы ввели не число, либо число в неверном формате!!!\n" +
                                      "Нажмите любую клавишу, чтобы попробовать снова...");
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

            Console.WriteLine("Нажмите любую клавишу, чтобы сложить введенные числа...");
            Console.ReadKey();
            Console.WriteLine($"Сумма чисел равна {Sum(Num1, Num2)}"); 
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            new Calculator();
        }
    }
}