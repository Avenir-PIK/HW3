namespace _3_bigger_of_four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводятся четыре числа. Вывести большее из них\n не используя Math, на сколько я понял");
            Console.WriteLine("Введите первое число");
            double dig1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double dig2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double dig3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите четвертое число");
            double dig4 = Convert.ToDouble(Console.ReadLine());

            double maxdig = dig1;

            if (dig2 > maxdig) maxdig = dig2;
            if (dig3 > maxdig) maxdig = dig3;
            if (dig4 > maxdig) maxdig = dig4;

            Console.WriteLine("\n{0} - наибольшее число\n", maxdig);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}