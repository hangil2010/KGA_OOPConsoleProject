using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class DocHouseScene : BaseScene
    {
        public DocHouseScene()
        {
            name = "DocHouse";
        }
        

        public override void Render()
        {
            Console.WriteLine("닥 미첼의 집에서 꺠어나다");
            Console.WriteLine("마을 밖으로 나간다");
        }
        public override void Input()
        {
            Console.ReadKey(true);
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
