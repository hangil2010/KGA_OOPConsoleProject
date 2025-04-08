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
        };
        private static BaseScene curScene;
        private static string prevSceneName;
        private static bool gameOver;
        public static Player player = new Player();
        public static ConsoleKey key;

        // 게임 진행도 체크용
        // 1. 신규 캐릭터를 생성했나?
        public static bool[] gameProgess = new bool[]
        {
            //0. 신규 캐릭터를 생성했나?
            false,
        };
        public static void Run()
        {
            Start();
            while (!gameOver)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }

        public static void Start()
        {
            gameOver = false;
            curScene = sceneDic["Title"];
        }

        public static void End()
        {

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
