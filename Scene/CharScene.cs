using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class CharScene : BaseScene
    {
        public CharScene()
        {
            name = "Char";
        }
        public override void Input()
        {
        }

        public override void Render()
        {
            Console.WriteLine("캐릭터 생성 씬");
        }

        public override void Result()
        {
            Game.ChangeScene("DocHouse");
        }

        public override void Update()
        {
        }
    }
}
