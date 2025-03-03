namespace _11_two_houses_on_uchastok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.");
            Console.WriteLine("\nВведите число a\n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число b\n");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите число p\n");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число q\n");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите число r\n");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число s\n");
            int s = Convert.ToInt32(Console.ReadLine());

            // жуть какая-то, решение не нравится.

            if      ((a >= (p + r)) && (b >= q && b >= s)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((a >= (q + r)) && (b >= p && b >= s)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((b >= (p + r)) && (a >= q && a >= s)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((b >= (q + r)) && (a >= p && a >= s)) Console.WriteLine("\nДа, разместить два дома возможно");

            else if ((a >= (p + s)) && (b >= q && b >= r)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((a >= (q + s)) && (b >= p && b >= r)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((b >= (p + s)) && (a >= q && a >= r)) Console.WriteLine("\nДа, разместить два дома возможно");
            else if ((b >= (q + s)) && (a >= p && a >= r)) Console.WriteLine("\nДа, разместить два дома возможно");
            else Console.WriteLine("\nНет, разместить два дома невозможно");


            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}