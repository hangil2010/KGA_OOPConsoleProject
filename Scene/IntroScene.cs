using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class IntroScene : BaseScene
    {
        public IntroScene()
        {
            name = "Intro";
        }
        
        public override void Render()
        {
            Console.WriteLine("인트로 스테이지");
            Console.WriteLine("세계관 소개를 여기서 하면 된다.");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Result()
        {
            Game.ChangeScene("Char");
        }

        public override void Update()
        {

        }
    }
}
