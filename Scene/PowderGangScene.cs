namespace OOPConsoleProject.Scene
{
    internal class PowderGangScene : BaseScene
    {
        public PowderGangScene() { name = "PowderGang"; }

        public override void Render()
        {
            Game.player.PrintInfo();
            if (Game.progess[5])
            {
                Util.Print("당신은 죽을 위협을 무릅쓰고 파우더 갱에게 다가갑니다.\n");
                Util.Print("파우더 갱단들은 당신을 죽여라 노려보지만 공격하지는 않습니다.\n");
                Util.Print("조 콥 : 너 뭐냐? 죄수복이 없는 걸 보니 파우더 갱은 아닌 거 같고 왜 왔냐?\n");
                Util.Print("왜 왔는지 빨리 안 말하면 여기가 니 무덤이 될거야\n");
                Console.WriteLine("1. 파우더 갱단들에게 링고의 위치를 발설한다");
                Console.WriteLine("2. 파우더 갱단들이 누구냐?");
                Console.WriteLine   ("3. NCR에 대해 물어본다");
                Console.WriteLine("[CHR 7] [LUK 7] 4. 파우더 갱어들에게 링고가 NCR 마을 근처에서 보였다는 거짓말을 한다.");
                Console.WriteLine("[STR 8] 5. 파우더 갱어들에게 \"정중히\" 이 마을에서 꺼지라고 말한다.");
                Console.WriteLine("S. 마을 남쪽으로 돌아간다");
            }
            else
            {
                Util.Print("파우더 갱어들이 거주하고 있는 기지입니다\n");
                Util.Print("위협적인 남성들이 당신을 노려보고 있습니다.\n");
                Util.Print("지금은 굳이 건드리지 않는 것이 좋아보인다.\n");
                Console.WriteLine("아무 키를 눌러 마을 남쪽으로 돌아갑니다.\n");
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
                if (Game.progess[5])
                {
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            Util.Print("그래.. 링고 그놈이 거기에 숨어있었다고?\n");
                            Util.Print("그게 사실이라면 지금까지 거짓말을 해왔다는 거네\n");
                            Util.Print("하.. 조용히 갈려고 했는데 안되겠네, 굿 스프링스를 우리 본거지로 만들러 간다\n");
                            Util.Print("너는 좋은 정보원이야, 우리 갱단에 합류해서 같이 마을을 지배하러 가자\n");
                            Game.GameClear = true;
                            break;
                        case ConsoleKey.D2:
                            Util.Print("우리? 우리들 소문을 못 들어본거면 어디 벙커 밑에서 살다가 왔나?\n");
                            Util.Print("저기 근처에 NCR 교도소에서 단체로 탈옥해서 우리를 가둔 NCR에게 복수하려고 하는 집단이다\n");
                            Util.Print("나는 대장 조 콥이라고 한다.\n");
                            break;
                        case ConsoleKey.D3:
                            Util.Print("NCR? 그놈들이 우리가 감옥에 간 이유지\n");
                            Util.Print("저기 캘리포니아 쪽에서 핵전쟁 이후 새로 세운 나라야\n");
                            Util.Print("처음엔 그쪽 동네에서만 놀던 놈들이 점점 세력 확장을 해서 이곳 모하비 지부까지 왔어\n");
                            break;
                        case ConsoleKey.D4:
                            if (Game.player.Charisma < 7 || Game.player.Luck < 7)
                            {
                                Util.Print("하.. 거짓말도 못하는구나 너, 거짓말이라고 얼굴에 쓰여있어\n");
                                Util.Print("거짓말 칠 정도로 한가한가 보네 굿 스프링스는\n");
                                Util.Print("얘들아 이녀석 손 한번 봐줘라\n");
                                Util.Print("이제 기다리는 건 지쳤다. 이제 굿 스프링스까지 치러간다\n");
                                Game.GameOver = true;
                            }
                            else
                            {
                                Util.Print("그래? 그놈이 거기로 도망쳤다고?\n");
                                Util.Print("만약 그게 사실이라면, NCR를 통해 역공을 할려고 준비하는건가?\n");
                                Util.Print("시간이 부족하다, 저 쪼그만 마을은 나중에 해결하고 우선 그곳으로 옮긴다\n");
                                Util.Print("갔는데 거짓말이면, 너랑 저 마을 둘다 지도에서 없애버릴꺼다\n");
                                Game.GameClear = true;
                            }
                            break;
                        case ConsoleKey.D5:
                            if (Game.player.Strength < 8)
                            {
                                Util.Print("뭐? 당장 이 마을을 꺼지라고? 거 참 웃긴 말이네\n");
                                Util.Print("바람 불면 날아갈 것 처럼 생긴 놈이 말이 많네\n");
                                Util.Print("가서 엄마 젖 좀 더 먹고 와라 아기야\n");
                            }
                            else
                            {
                                Util.Print("너가 누구길래 다짜고짜 와서 누구보고 가라마라야!\n");
                                Util.Print("뭐? 오는길에 부하들을 전부 때려눕히고 왔다고?\n");
                                Util.Print("그럴리가, 내 부하들은 한 체격하는 놈들로 구성했는데 사실이야?\n");
                                Util.Print("야 가서 조사좀 해봐 무슨 일이 일어났는지\n");
                                Util.Print("아.. 굿 스프링스에 이런 인재가 있었을 줄이면 감히 안 건드렸죠 ㅎㅎ\n");
                                Util.Print("다시는 이 마을을 안 건드리겠습니다 제발 떄리지 말아주세요..\n");
                                Game.GameClear = true;
                            }
                            break;
                        case ConsoleKey.S:
                            targetScene = "TownSouth";
                            Console.WriteLine("마을 남쪽으로 돌아갑니다.");
                            break;

                    }
                }
                else
                {
                    targetScene = "TownSouth";
                    Console.WriteLine("마을 남쪽으로 돌아갑니다.");
                }
            }
            else
            {
                Game.player.Inventory.Open();
            }

            Console.ReadKey();
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
