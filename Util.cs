using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Util
    {
        public static int IntInput(int start, int end)
        {
            int result = 0;
            Console.WriteLine($"{start}이상 {end}이하 숫자를 입력하세요");
            while (!(int.TryParse(Console.ReadLine(), out result) && (start <= result && result <= end)))
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
            return result;
        }

        public static void Print(string context, ConsoleColor backColor = ConsoleColor.Black, ConsoleColor textColor = ConsoleColor.White, int delay = 1500)
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = textColor;
            Console.Write(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
