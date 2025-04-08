using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int x, int y) 
        { 
            this.x = x; this.y = y;
        }

        public static bool operator ==(Vector2 left, Vector2 right) 
        {
            return left.x == right.x && left.y == right.y;
        }
        public static bool operator !=(Vector2 left, Vector2 right) 
        {
            return left.x != right.x || left.y != right.y;
        }
    }

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

        public static void Print(string context, ConsoleColor backColor = ConsoleColor.Black, ConsoleColor textColor = ConsoleColor.White, int delay = 2000)
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = textColor;
            Console.Write(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
