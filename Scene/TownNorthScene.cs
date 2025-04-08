using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class TownNorthScene : BaseScene
    {

        public TownNorthScene()
        {
            name = "TownNorth";
        }
        

        public override void Render()
        {
            Console.WriteLine("굿 스프링스 마을 북쪽");
            Console.WriteLine("1. 닥 미첼의 집으로 들어간다");
            Console.WriteLine("2. 버려진 오두막으로 간다");
            Console.WriteLine("3. 굿 스프링스 공동묘지로 간다");
            Console.WriteLine("C : 마을 중앙으로 이동");
        }
        public override void Input()
        {
            Game.key = Console.ReadKey(false).Key;
        }
        public override void Result()
        {
            switch (Game.key) 
            {
                case ConsoleKey.D1:
                    Console.WriteLine("닥 미첼의 집으로 들어갑니다");
                    Game.ChangeScene("DocHouse");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("버려진 오두막으로 이동합니다");
                    Game.ChangeScene("AbandonShack");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("굿 스프링스 공동묘지로 향합니다");
                    Game.ChangeScene("Cemetry");
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
