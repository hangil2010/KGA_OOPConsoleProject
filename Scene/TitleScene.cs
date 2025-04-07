using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    public class TitleScene : BaseScene
    {
        public TitleScene()
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*   Fallout New Vegas   *");
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }


        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Result()
        {
            Game.ChangeScene("Char");
        }

        public override void Update() { }
    }
}
