namespace _11_two_houses_on_uchastok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.");
            Console.WriteLine("\nВведите число a\n");
            int dig_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число b\n");
            int dig_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число p\n");
            int dig_p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число q\n");
            int dig_q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число r\n");
            int dig_r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число s\n");
            int dig_s = Convert.ToInt32(Console.ReadLine());

            // надо подумать как это сделать не на 100500 строк =)
            
            if (dig1 <= -10 || dig1 >= 10) Console.WriteLine("\nДа");
            
            
            else Console.WriteLine("\nНет");


            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}