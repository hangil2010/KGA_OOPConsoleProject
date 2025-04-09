using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class TownWestScene : BaseScene
    {
        public TownWestScene() { name = "TownWestScene"; }

        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("굿 스프링스 마을 서쪽입니다");
            Console.WriteLine("1. 빅터의 오두막으로 갑니다");
            Console.WriteLine("C. 마을 중앙으로 갑니다");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            string targetScene = "";
            switch (input)
            {
                
                case ConsoleKey.D1:
                    Console.WriteLine("빅터의 오두막으로 들어갑니다");
                    Game.ChangeScene("VictorShack");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("마을 중앙으로 이동합니다");
                    Game.ChangeScene("TownCenter");
                    break;
                default:
                    Console.WriteLine("잘못된 키를 입력하셨습니다");
                    break;
            }
            if(targetScene != "")
            {
                Console.ReadKey();
                Game.ChangeScene(targetScene);
            }
        }

        public override void Update()
        {
        }
    }
}
