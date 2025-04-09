using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class TownSouthScene : BaseScene
    {
        public TownSouthScene() { name = "TownSouth"; }

        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("굿 스프링스 마을 남쪽이다");
            Console.WriteLine("1. 굿 스프링스 물탱크");
            Console.WriteLine("2. 파우더 갱 전초기지로 간다");
            Console.WriteLine("C. 마을 중앙으로 이동한다");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("굿 스프링스 물탱크로 들어갑니다");
                    Game.ChangeScene("WaterTank");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("파우더 갱 전초기지로 이동합니다");
                    Game.ChangeScene("PowderGang");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("마을 중앙으로 이동합니다");
                    Game.ChangeScene("TownCenter");
                    break;
                default:
                    Console.WriteLine("잘못된 키를 입력하셨습니다");
                    break;
            }
            Console.ReadKey();
        }

        public override void Update()
        {
        }
    }
}
