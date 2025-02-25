namespace _4_middle_of_three_different_doubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводятся три разных числа. Вывести медиану – среднее по величине число.");
            Console.WriteLine("Введите первое число");
            double dig1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double dig2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double dig3 = Convert.ToDouble(Console.ReadLine());

            // находим максимум как в прошлой задаче, затем минимум аналогично, после чего максимум и минимум вычитаем из суммы, тем самым находя третье число
            double maxdig = dig1;
            if (dig2 > maxdig) maxdig = dig2;
            if (dig3 > maxdig) maxdig = dig3;
            double mindig = dig1;
            if (dig2 < mindig) mindig = dig2;
            if (dig3 < mindig) mindig = dig3;
            double middig = dig1 + dig2 + dig3 - maxdig - mindig;

            Console.WriteLine("\n{0} - медиана\n", middig);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}