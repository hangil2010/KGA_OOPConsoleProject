using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class ChetShopScene : BaseScene
    {
        public ChetShopScene() { name = "ChetShop"; }
        
        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("쳇의 상점입니다.");
        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            Game.ChangeScene("TownEast");
        }

        public override void Update()
        {
        }
    }
}
