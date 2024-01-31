namespace Mod10FinPractice
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            while (true)
            {
                Logger = new Logger();
                int a = 0, b = 0;
                try
                {
                    Console.WriteLine("Введите значение 1 слагаемого");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение 2 слагаемого");
                    b = Convert.ToInt32(Console.ReadLine());
                    Calc calc = new Calc(Logger);
                    Console.WriteLine(calc.Sum(a, b));
                }
                catch (Exception ex)
                {
                    Logger.Error("Что-то не так...");
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
