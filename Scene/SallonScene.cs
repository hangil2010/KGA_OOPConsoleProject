using OOPConsoleProject.GameObject;

namespace OOPConsoleProject.Scene
{
    internal class SallonScene : BaseScene
    {
        public SallonScene() { name = "Sallon"; }
        public Drink drink = new Drink("위스키", "체력을 50 회복시켜줍니다", 50);

        public override void Render()
        {
            if(Game.player.quest.Contains("트루디의 술집으로 가보자"))
            {
                Game.player.quest.Remove("트루디의 술집으로 가보자");
            }
            Game.player.PrintInfo();
            Console.WriteLine("탄광꾼의 술집에 들어갔습니다.");
            Console.WriteLine("트루디가 주인으로 운영하고 있습니다.");
            // 술집의 소란을 목격하였는가?
            if (!Game.progess[2])
            {
                Console.WriteLine("술집 구석에서 소란이 들립니다.");
                Console.WriteLine("1. 소란을 자세히 확인하러 갑니다");
                Console.WriteLine("E. 소란을 무시하고 나갑니다.");
            }
            else
            {
                Util.Print("어서와 배달부");
                Console.WriteLine("1. 자신을 쏜 남자에 대해 물어본다");
                Console.WriteLine("2. 술집에서 시비를 건 남자에 대해 물어본다");
                // 트루디의 고장난 라디오를 고쳤는가?
                if (!Game.progess[3])
                {
                    Console.WriteLine("3. [INT 7] : 트루디의 술집에 방치된 고장난 라디오를 고쳐본다.");
                }
                Console.WriteLine("E. 술집을 나갑니다.");

            }

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
                // 술집의 소란을 목격했는가
                if (!Game.progess[2])
                {
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            Util.Print("소동을 확인해보니 경찰 조끼를 입은 남성이 트루디에게 시비를 걸고 있었습니다\n");
                            Util.Print("??? : 링고 이놈이 여기 굿스프링스로 도망치는 걸 봤단 말이야.\n");
                            Util.Print("??? : 당장 위치를 안 말하면 내가 이 마을을 쑥대맡으로 만들꺼야\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 내가 말했지, 그놈에 대해 하나도 모른다고\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 설령 내가 알아도 너같은 범죄자들한테 말할꺼 같아?\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 그럼 뭐 살꺼 아니면 당장 이 술집에서 나가\n");
                            Console.ReadKey();
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 하.. 겨우 조용해졌네, 내 술집에 온걸 환영해 배달부\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 빅터한테 들었어, 머리에 총상을 맞고도 살아남았다고\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 술 한잔 마시면서 기억을 복돋아보는건 어때?\n");
                            Game.progess[2] = true;
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("내 상관은 아니지, 당신은 소동을 무시하고 조용해지길 기다리며 마을 밖으로 나갑니다.");
                            targetScene = "TownEast";
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다");
                            break;
                    }
                    Console.ReadKey();
                }
                else
                {
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 나도 잘 모르겠어, 이 마을의 모든 일은 다 알고 있다 생각했는데 온 줄도 몰랐어\n");
                            break;
                        case ConsoleKey.D2:
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 아 저놈? 근처 NCR 감옥에서 반란을 일으키고 그곳을 본거지로 한 집단들이 있어.\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 자기들을 파우더 갱이라고 부르더라고\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 그 중 조 콥이란 저 사람은 파우더 갱의 리더로 최근 한 남자를 쫓고 있어\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 링고라는 남성인데 파우더 갱한테 자신의 팀원들이 몰살당하고 겨우 이 마을로 도망쳐왔어\n");
                            Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                            Util.Print(": 그 뒤로 마을 북쪽에 있는 오두막에 링고를 숨겨둔 뒤로 하루가 멀다하고 협박을 하러 오네\n");
                            // 마을의 문제를 해결하기로 했다.
                            if (!Game.progess[4])
                            {
                                Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                                Util.Print(": 잠깐, 머리에 총을 맞고도 술마시러 올 정도의 사람이라면, 너가 이 문제를 해결할 수 있을 것 같아\n");
                                Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                                Util.Print(": 링고한테 가서 말을 걸어봐, 오두막으로 가서 바닥을 잘 살펴보면 숨겨진 문이 있을 꺼야\n");
                                Game.player.quest.Add("마을 북쪽의 오두막에 가보자.");
                                Game.progess[4] = true;
                            }
                            break;
                        case ConsoleKey.D3:
                            if (Game.player.Special.Charisma < 7)
                            {
                                Console.WriteLine("고쳐보려고 라디오를 이리 저리 둘러보았으나 해결할 방법이 생각나지 않습니다.");
                                Console.WriteLine("괜히 문제를 일으키고 싶지 않아 내려놓습니다.");
                            }
                            else
                            {
                                Console.WriteLine("당신은 능숙하게 라디오 내부의 고장난 부품을 납땜해나갑니다");
                                Console.WriteLine("몇 번의 납땜 이후 라디오에서 소리가 들려나오기 시작합니다");
                                Util.Print("트루디", textColor: ConsoleColor.DarkGreen, delay: 0);
                                Console.WriteLine(": 라디오를 고쳐줘서 고마워, 너의 노력에 대한 선물이야");
                                Game.player.Caps += 200;
                                Console.WriteLine("200캡을 획득하였습니다.");
                                Game.player.Inventory.Add(drink);
                                // 트루디의 라디오를 고쳤다.
                                Game.progess[3] = true;
                            }
                            break;
                        case ConsoleKey.E:
                            targetScene = "TownEast";
                            Console.WriteLine("마을 동쪽으로 나갑니다");
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다");
                            break;
                    }
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
