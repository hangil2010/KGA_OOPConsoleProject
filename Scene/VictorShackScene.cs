using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class VictorShackScene : BaseScene
    {
        public VictorShackScene() { name = "VictorShack"; }
        public override void Input()
        {
            input = Console.ReadKey().Key;
        }

        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("빅터의 오두막");
            Console.WriteLine("나를 구해줬던 친절한 이웃이 살고 있는 집이다.");

        }

        public override void Result()
        {
            if(input != ConsoleKey.I)
            {
                Game.ChangeScene("TownWest");
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
