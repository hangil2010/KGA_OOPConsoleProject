using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class DocHouseScene : BaseScene
    {
        public override void Input()
        {
        }

        public override void Render()
        {
            Console.WriteLine("닥 미첼의 집에서 꺠어나다");
        }

        public override void Result()
        {
            Game.ChangeScene("TownCenter");
        }

        public override void Update()
        {
        }
    }
}
