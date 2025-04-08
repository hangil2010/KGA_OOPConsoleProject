using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class TownEastScene : BaseScene
    {
        public TownEastScene() { name = "TownEast"; }

        public override void Render()
        {
            Console.WriteLine("굿 스프링스 동쪽입니다.");
            Console.WriteLine("1. 쳇의 상가로 갑니다");
            Console.WriteLine("2. 트루디의 술집으로 갑니다");
            Console.WriteLine("C. 마을 중앙으로 이동합니다");
        }
        public override void Input()
        {
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("쳇의 상가로 들어갑니다");
                    Game.ChangeScene("ChetShop");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("트루디의 술집으로 이동합니다");
                    Game.ChangeScene("Sallon");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("마을 중앙으로 이동합니다");
                    Game.ChangeScene("TownCenter");
                    break;
                default:
                    Console.WriteLine("잘못된 키를 입력하셨습니다");
                    break;
            }
        }

        public override void Update()
        {
        }
    }
}
