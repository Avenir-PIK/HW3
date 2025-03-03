namespace _5_YES_if_end_on_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.");
            Console.WriteLine("Введите число\n");
            // дабл или инт? по условию число, скорее всего инт
            int dig1 = Convert.ToInt32(Console.ReadLine());

            if (dig1 %10 == 0) Console.WriteLine("\nДа");
            else Console.WriteLine("\nНет");

            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}