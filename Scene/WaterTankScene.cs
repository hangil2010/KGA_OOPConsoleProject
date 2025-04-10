using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class WaterTankScene : BaseScene
    {
        public WaterTankScene() { name = "WaterTank"; }
        

        public override void Render()
        {
            Game.player.PrintInfo();
            Util.Print("마을 남쪽에 위치한 물 저장소이다.\n");
            Util.Print("빅터가 물을 플라스틱 병에 나누어 담고 있다.\n");
            Util.Print("빅터", textColor: ConsoleColor.Green);
            Util.Print(": 오 배달부, 잘 지내고 있는가보네!\n");
            Util.Print("빅터", textColor: ConsoleColor.Green);
            Util.Print(": 몸은 좀 어때?\n");
            Util.Print("빅터", textColor: ConsoleColor.Green);
            Util.Print(": 아 나? 지금 트루디 아주머니가 부탁해서 물을 떠나르고 있어\n");
            Util.Print("빅터", textColor: ConsoleColor.Green);
            Util.Print(": 왜 직접 하지 않느냐고? 술집을 운영하는데 바쁘다고 하셔서 내가 하러 나왔어\n");
            Util.Print("빅터", textColor: ConsoleColor.Green);
            Util.Print(": 파우더 갱단들도 근처에 있어서 함부로 다가가는 게 위험하기도 하고\n");
        }

        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            if (input != ConsoleKey.I)
            {
                Game.ChangeScene("TownSouth");
            }
            else
            {
                Game.player.Inventory.Open();
            }
        }

        public override void Update()
        {
        }
    }
}
