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
        

        public override void Render()
        {
            Util.Print("새로운 캐릭터를 생성합니다");
            Util.Print("캐릭터의 능력치를 설정합니다.");
            Util.Print("아무 키나 눌러 진행하세요");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Result()
        {
            Console.Clear();
            Game.player.SetSpecial();
            Game.ChangeScene("DocHouse");
        }

        public override void Update()
        {
        }
    }
}
