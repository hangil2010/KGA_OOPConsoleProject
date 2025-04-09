using OOPConsoleProject.Scene;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

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
        };
        private static BaseScene curScene;
        private static string prevSceneName;
        private static bool gameOver;
        public static bool GameOver {  get { return gameOver; } set { gameOver = value; } }
        private static bool gameClear;
        public static bool GameClear { get { return gameClear; } set { gameClear = value; } }
        public static Player player = new Player();

        // 게임 진행도 체크용
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
        };
        public static void Run()
        {
            Start();
            while (gameOver == false && gameClear == false)
            {
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

        public static void End()
        {
            Console.Clear();
            Console.WriteLine("게임 끝");
        }

        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;
            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }

    }
}
