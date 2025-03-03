namespace _1_compare_two_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».\n");
            Console.WriteLine("Введите первое число");
            double dig1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double dig2 = Convert.ToDouble(Console.ReadLine());

            if (dig1 == dig2)
            {
                Console.WriteLine("{0} = {1}", dig1, dig2);
            }
            if (dig1 > dig2)
            {
                Console.WriteLine("{0} > {1}", dig1, dig2);
            }
            if (dig1 < dig2)
            {
                Console.WriteLine("{0} < {1}", dig1, dig2);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
