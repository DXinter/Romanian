using System;

namespace Romanian

{
    /*
     * extension method, конвертирующий int в строку с римским представлением этого числа: 24.ToRomanaian() => "XXIV"
     */
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число = ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            string Romanian = numbers.ToRomanian();
            Console.WriteLine($"Число в римской системе = {Romanian}");
            Console.ReadLine();
        }
    }
}
