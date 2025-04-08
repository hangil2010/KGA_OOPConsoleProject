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
            Console.WriteLine("빅터의 오두막이다");
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
