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
                Console.WriteLine("당신은 죽을 위협을 무릅쓰고 파우더 갱에게 다가갑니다.");
                Console.WriteLine("파우더 갱단들은 당신을 죽여라 노려보지만 공격하지는 않습니다.");
                Console.WriteLine("조 콥 : 너 뭐냐? 죄수복이 없는 걸 보니 파우더 갱은 아닌 거 같고 왜 왔냐?");
                Console.WriteLine("왜 왔는지 빨리 안 말하면 여기가 니 무덤이 될거야");
                Console.WriteLine("1. 파우더 갱단들에게 링고의 위치를 발설한다");
                Console.WriteLine("2. 파우더 갱단들이 누구냐?");
                Console.WriteLine("3. NCR에 대해 물어본다");
                Console.WriteLine("[CHR 7] 4. 파우더 갱어들에게 링고가 NCR 마을 근처에서 보였다는 거짓말을 한다.");
                Console.WriteLine("[STR 8] 5. 파우더 갱어들에게 \"정중히\" 이 마을에서 꺼지라고 말한다.");
                Console.WriteLine("S. 마을 남쪽으로 돌아간다");
            }
            else
            {
                Console.WriteLine("파우더 갱어들이 거주하고 있는 기지입니다");
                Console.WriteLine("위협적인 남성들이 당신을 노려보고 있습니다.");
                Console.WriteLine("지금은 굳이 건드리지 않는 것이 좋아보인다.");
            }
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            string targetScene = "";
            if (Game.progess[5])
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("1번 텍스트");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("2번 텍스트");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("3번 텍스트");
                        break;
                    case ConsoleKey.D4:
                        if(Game.player.Charisma < 7)
                        {
                            Console.WriteLine("하.. 거짓말도 못하는구나 너, 거짓말이라고 얼굴에 쓰여있어");
                            Console.WriteLine("거짓말 칠 정도로 한가한가 보네 굿 스프링스는");
                            Console.WriteLine("얘들아 이녀석 손 한번 봐줘라");
                            Console.WriteLine("이제 기다리는 건 지쳤다. 이제 굿 스프링스까지 치러간다");
                            Game.GameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("그래? 그놈이 거기로 도망쳤다고?");
                            Console.WriteLine("만약 그게 사실이라면, NCR를 통해 역공을 할려고 준비하는건가?");
                            Console.WriteLine("시간이 부족하다, 저 쪼그만 마을은 나중에 해결하고 우선 그곳으로 옮긴다");
                            Console.WriteLine("갔는데 거짓말이면, 너랑 저 마을 둘다 지도에서 없애버릴꺼다");
                            Game.GameClear = true;
                        }
                            break;
                    case ConsoleKey.D5:
                        if(Game.player.Strength < 8)
                        {
                            Console.WriteLine("뭐? 당장 이 마을을 꺼지라고? 거 참 웃긴 말이네");
                            Console.WriteLine("바람 불면 날아갈 것 처럼 생긴 놈이 말이 많네");
                            Console.WriteLine("가서 엄마 젖 좀 더 먹고 와라 아기야");
                        }
                        else
                        {
                            Console.WriteLine("너가 누구길래 다짜고짜 와서 누구보고 가라마라야!");
                            Console.WriteLine("뭐? 오는길에 부하들을 전부 때려눕히고 왔다고?");
                            Console.WriteLine("그럴리가, 내 부하들은 한 체격하는 놈들로 구성했는데 사실이야?");
                            Console.WriteLine("야 가서 조사좀 해봐 무슨 일이 일어났는지");
                            Console.WriteLine("아.. 굿 스프링스에 이런 인재가 있었을 줄이면 감히 안 건드렸죠 ㅎㅎ");
                            Console.WriteLine("다시는 이 마을을 안 건드리겠습니다 제발 떄리지 말아주세요..");
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

            Console.ReadKey();
            if (targetScene != "")
            {
                Game.ChangeScene("TownSouth");
            }
        }

        public override void Update()
        {
        }
    }
}
