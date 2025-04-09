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
            Console.ReadKey();
        }

        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("빅터의 오두막");
            Console.WriteLine("나를 구해줬던 친절한 이웃이 살고 있는 집이다.");

        }

        public override void Result()
        {
            Game.ChangeScene("TownWest");
        }

        public override void Update()
        {

        }
    }
}
