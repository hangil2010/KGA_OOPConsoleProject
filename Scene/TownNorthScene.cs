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
            Game.player.PrintInfo();
            // 캐릭터를 생성하고 나갔을 때 빅터가 나와서 특별한 대사를 하게 함
            // 1회성 대사로 이후에는 나오지 않게 한다.
            // progress[1] : 빅터를 처음 만났는가?
            if (!Game.progess[1]) 
            {
                //Util.Print("빅터", textColor : ConsoleColor.Green);
                //Util.Print(" : 오 친구! 깨어났네!\n");
                //Util.Print("미첼 박사님은 좋은 의사선생님이야, 마을의 모든 의료시설을 담당할 정도로 유능하신 분이지\n");
                //Util.Print("난 마을 서쪽 오두막에서 살고 있어, 만나고 싶을 때 와서 만나면 될꺼야\n");
                //Util.Print("그럼 이만!\n");
            }
            Console.WriteLine("굿 스프링스 마을 북쪽");
            Console.WriteLine("1. 닥 미첼의 집으로 들어간다");
            Console.WriteLine("2. 버려진 오두막으로 간다");
            Console.WriteLine("3. 굿 스프링스 공동묘지로 간다");
            Console.WriteLine("C : 마을 중앙으로 이동");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            Game.progess[1] = true;
            string targetScene = "";
            if (input != ConsoleKey.I)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("닥 미첼의 집으로 들어갑니다");
                        targetScene = "DocHouse";
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("버려진 오두막으로 이동합니다");
                        targetScene = "AbandonShack";
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("굿 스프링스 공동묘지로 향합니다");
                        targetScene = "Cemetry";
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("마을 중앙으로 이동합니다");
                        targetScene = "TownCenter";
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
