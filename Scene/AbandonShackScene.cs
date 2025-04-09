using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class AbandonShackScene : BaseScene
    {
        public AbandonShackScene() { name = "AbandonShack"; }  

        public override void Render()
        {
            if(Game.player.quest.Contains("마을 북쪽의 오두막에 가보자."))
            {
                Game.player.quest.Remove("마을 북쪽의 오두막에 가보자.");
            }
            Game.player.PrintInfo();
            Console.WriteLine("버려진 오두막");
            if (Game.progess[4])
            {
                if (!Game.progess[5]) 
                {
                    Console.WriteLine("바닥을 훑어보니 열 수 있을 것 같은 문이 보입니다.");
                    Console.WriteLine("1. 연다");
                    Console.WriteLine("N. 열지 않고 나간다.");
                }
                else 
                {
                    Console.WriteLine("1. 링고에게 나를 쏜 남자에 대해 물어본다.");
                    Console.WriteLine("2. 자신이 운영하던 사업에 대해 물어본다.");
                    Console.WriteLine("N. 마을 북쪽으로 나간다");
                }
            }
            else
            {
                Console.WriteLine("아무도 없는 듯 합니다..");
            }
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
                if (Game.progess[4])
                {
                    if (!Game.progess[5])
                    {
                        switch (input)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("바닥의 문을 열자 크게 겁에 질린 한 남자가 나타났다.");
                                Console.WriteLine("링고 : 파우더 갱이냐! 어서 신원을 밝혀라.");
                                Console.WriteLine("총구를 크게 떨고 있는 링고를 진정시키고 트루디의 소개로 왔다고 말한다.");
                                Console.WriteLine("아 트루디 아주머니께서 보내셨구나. 다행이다.. 결국 그놈들이 날 찾았나 싶었어");
                                Console.WriteLine("링고라고 해, 이전에 작은 캐러밴을 운영했는데 파우더 갱한테 습격당하고 이곳으로 겨우 도망쳤어");
                                Console.WriteLine("저놈들이 마지막 목격자를 없애려고 나를 찾을려고 하고 있어");
                                Console.WriteLine("트루디 아주머니께서 너를 소개한걸 보면, 너가 이 일에 적합자인 것 같아.");
                                Console.WriteLine("혹시 미친 소리일 수도 있지만, 파우더 갱을 이 마을에서 쫓아낼 수 있어?");
                                Console.WriteLine("너 정도의 능력이면 이 마을에 평화를 되찾을 수 있을 것 같아");
                                Console.WriteLine("쫒아내 준다면 내가 어떻게든 보상할께, 가진걸 다 잃어서 지금 많이는 없지만 본부로 무사히 돌아간다면 크게 보상해줄께");
                                Game.player.quest.Add("굿 스프링스와 파우더 갱 사이의 문제를 해결하자");
                                Game.progess[5] = true;
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("아직 모를 위협에 준비가 되지 않았다. 일단 밖으로 나가자");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (input)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("아쉽게도 계속 밑에서 숨어있느라 아는게 없어");
                                Console.WriteLine("총성이 크게 들려서 결국 파우더 갱이 마을을 습격한 것으로 생각했어");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("베가스 중심지 근처에서 진홍상회를 운영하고 있어");
                                Console.WriteLine("신규 교역로를 찾으러 조사하러 나왔다가 봉변을 당하고 이곳으로 오게 됬어.");
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("마을 북쪽으로 돌아갑니다");
                                targetScene = "TownNorth";
                                break;
                            default:
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    targetScene = "TownNorth";
                    Console.WriteLine("마을 북쪽으로 돌아갑니다");
                    Console.ReadKey();
                }
            }
            else
            {
                Game.player.Inventory.Open();
            }
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
