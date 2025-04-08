using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class CemetryScene : BaseScene
    {
        public CemetryScene() { name = "Cemetry"; }
        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Render()
        {
            Console.WriteLine("굿 스프링스 공동묘지");
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
