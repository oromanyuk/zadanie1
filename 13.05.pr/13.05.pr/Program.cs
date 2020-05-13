using System;

namespace _13._05.pr
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "xeveer";
            Console.WriteLine("1. Повтор: " + lib1.stpow(a, 3));
            Console.WriteLine("2. Реверс: " + lib1.rev(a));
            Console.WriteLine("3. Удаление: " + lib1.remov(a, "e"));
            Console.WriteLine("4. Количество символов: " + lib1.leng(a));
        }
    }
}
