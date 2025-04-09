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
            if(Game.player.quest.Contains("챗의 상점으로 가보자"))
            {
                Game.player.quest.Remove("챗의 상점으로 가보자");
            }
            Game.player.PrintInfo();
            Console.WriteLine("쳇의 상점입니다.");
        }
        public override void Input()
        {
            input = Console.ReadKey().Key;
        }
        public override void Result()
        {
            if(input != ConsoleKey.I)
            {
                Game.ChangeScene("TownEast");
            }
            else
            {
                Game.player.Inventory.Open();
            }
        }

        public override void Update()
        {
        }
    }
}
