using OOPConsoleProject.Scene;

namespace OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic = new()
        {
            {"Title", new TitleScene()},
            {"Char", new CharScene() },
            {"TownCenter", new TownCenterScene() },
            {"TownNorth", new TownNorthScene() },
            {"TownSouth", new TownSouthScene() },
            {"TownWest", new TownWestScene() },
            {"TownEast", new TownEastScene() },
            {"DocHouse", new DocHouseScene() },
            {"AbandonShack", new AbandonShackScene() },
            {"Cemetry", new CemetryScene() },
            {"PowderGang", new PowderGangScene() },
            {"Sallon", new SallonScene() },
            {"VictorShack", new VictorShackScene() },
            {"WaterTank", new WaterTankScene() },
            {"Intro", new IntroScene() },
            {"ChetShop", new ChetShopScene() },
            {"Battle", new BattleScene() },
        };
        private static BaseScene curScene;
        private static string prevSceneName;
        private static bool gameOver;
        public static bool GameOver { get { return gameOver; } set { gameOver = value; } }
        private static bool gameClear;
        public static bool GameClear { get { return gameClear; } set { gameClear = value; } }
        public static Player player = new Player();

        // 게임 진행도 체크용
        // 진행도에 따라 특정 대사가 출력되게 함.
        public static bool[] progess = new bool[]
        {
            //0. 신규 캐릭터를 생성했나?
            false,
            //1. 빅터를 처음 만났나?
            false,
            //2. 술집에서 조 콥의 소동을 목격했는가?
            false,
            //3. 술집의 라디오를 고쳤는가?
            false,
            //4. 트루디한테 링고의 위치에 대해 들었는가?                                 
            false,
            //5. 링고를 만나고 파우더 갱을 내보내기로 하였는가?
            false,
            //6. 당신을 쏜 사람의 단서를 찾아냈습니까?
            false,
            //7. 파우더 갱단의 문제를 평화적으로 해결하였는가
            false,
            //8. 파우더 갱단의 문제를 물리적으로 해결하였는가
            false,
        };
        public static void End()
        {
            Console.Clear();
            if (gameOver == true)
            {
                Console.WriteLine("게임 패배..");
            }
            else if (gameClear == true)
            {
                // 분기별 엔딩
                Console.WriteLine("게임 클리어!");
                if (progess[3] == false)
                {
                    Console.WriteLine("아쉽게도 트루디는 라디오를 고치지 못하였고, 결국 새로 구매하였습니다");
                }
                else
                {
                    Console.WriteLine("트루디는 라디오로 세상 이야기를 다시 들을 수 있게 되었습니다.");
                }
                if (progess[7] == true)
                {
                    Console.WriteLine("당신은 마을의 문제를 평화적으로 해결하였습니다!");
                }
                if (progess[8] == true)
                {
                    Console.WriteLine("당신은 마을의 문제를 당신의 물리적인 힘으로 해결하였습니다!");
                }
                if (progess[6] == true)
                {
                    Console.WriteLine("당신을 쏜 사람들에 대한 단서를 찾았습니다.");
                }
            }
        }

        public static void Run()
        {
            Start();
            while (gameOver == false && gameClear == false)
            {
                //일련의 게임 플레이 사이클
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
            End();
        }

        public static void Start()
        {
            gameOver = false;
            curScene = sceneDic["Title"];
        }



        public static void ChangeScene(string sceneName)
        {
            // 씬 변경
            prevSceneName = curScene.name;
            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }

    }
}
