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
            Console.WriteLine("마을 남쪽에 위치한 물 저장소이다.");
        }

        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            Game.ChangeScene("TownSouth");
        }

        public override void Update()
        {
        }
    }
}
