﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Util
    {
        // SPECIAL 입력을 위해 start~end 사이 값을 입력하게 한다.
        // 정수를 제대로 입력했고 && 시작과 끝 값 사이에 값이 입력될때 까지 입력을 반복
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
