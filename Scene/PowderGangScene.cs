using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class PowderGangScene : BaseScene
    {
        public PowderGangScene() { name = "PowderGang"; }

        public override void Render()
        {
            Console.WriteLine("파우더 갱어들이 거주하고 있는 기지입니다");
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
