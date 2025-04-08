using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class AbandonShackScene : BaseScene
    {
        public AbandonShackScene() { name = "AbandonShack"; }  

        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("버려진 오두막");
            Console.WriteLine("아무도 없는 듯 합니다..");
        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            Game.ChangeScene("TownNorth");
        }

        public override void Update()
        {

        }
    }
}
