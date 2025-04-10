using OOPConsoleProject.GameObject;
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
        private QuestItem cigar = new("누가 핀 담배", "누군가 최근에 핀 담배 입니다. 나를 쏜 그 남자들 중 한명이 핀 것 같습니다.");

        public override void Render()
        {
            Game.player.PrintInfo();
            Util.Print("굿 스프링스 공동묘지\n");
            Util.Print("얕게 묻힌 무덤이 보이고 금방 파내진듯 한 모습입니다.\n");
            Util.Print("직감적으로 저곳이 자신이 뭍힐뻔한 곳임을 눈치챘습니다.\n");
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
            if (input != ConsoleKey.I)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        //6. 당신을 쏜 사람의 단서를 찾아냈습니까?
                        if (!Game.progess[6]) 
                        { 
                            Console.WriteLine("얕은 무덤을 조사합니다.");
                            Util.Print("근처를 둘러보니 최근에 누가 핀 담배가 보였습니다.\n");
                            Util.Print("최근에 핀 것을 보아 당신을 쐈던 사람들 중 한명이 핀 것을 알아차립니다.\n");
                            Util.Print("단서를 찾아낸 당신은 담배를 주머니에 넣습니다.\n");
                            Game.player.quest.Remove("당신을 쏜 사람을 찾아보자.");
                            Game.player.Inventory.Add(cigar);
                            // 당신을 쏜 사람에 대한 단서를 알아냈습니다.
                            Game.progess[6] = true;
                        }
                        else
                        {
                            Console.WriteLine("이미 조사했습니다");
                        }
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
