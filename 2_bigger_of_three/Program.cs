namespace _2_bigger_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Вводятся три числа. Вывести большее их них\n не используя Math, на сколько я понял");
            Console.WriteLine("Введите первое число");
            double dig1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double dig2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double dig3 = Convert.ToDouble(Console.ReadLine());
            double maxdig = dig1;

            if (dig2 > maxdig) maxdig = dig2;
            if (dig3 > maxdig) maxdig = dig3;

            Console.WriteLine("\n{0} - наибольшее число\n", maxdig);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
