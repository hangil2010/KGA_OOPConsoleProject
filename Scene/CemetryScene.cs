using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class CemetryScene : BaseScene
    {
        public CemetryScene() { name = "Cemetry"; }


        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("굿 스프링스 공동묘지\n");
            Console.WriteLine("얕게 묻힌 무덤이 보이고 금방 파내진듯 한 모습입니다.");
            Console.WriteLine("직감적으로 저곳이 자신이 뭍힐뻔한 곳임을 눈치챘습니다.");
            Console.WriteLine("1. 얕은 무덤을 조사한다");
            Console.WriteLine("2. 저 멀리 시체를 파고 있는 변종 코요태에게 다가간다");
            Console.WriteLine("N. 굿 스프링스 마을 북쪽으로 돌아갑니다.");

        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            string targetScene = "";
            if(input != ConsoleKey.I)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("얕은 무덤을 조사합니다.");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("코요테들은 당신의 존재를 눈치채고 전투를 시작합니다.");
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("마을 북쪽으로 이동합니다");
                        targetScene = "TownNorth";
                        break;
                    default:
                        Console.WriteLine("잘못된 키를 입력하셨습니다");
                        break;
                }
            }
            else
            {
                Game.player.Inventory.Open();
            }

                Console.ReadKey(true);
            if (targetScene != "")
            {
                Game.ChangeScene(targetScene);
            }
        }

        public override void Update()
        {

        }
    }
}
