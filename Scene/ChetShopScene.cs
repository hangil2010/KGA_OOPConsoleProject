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
            Console.WriteLine("쳇 : 내 상점에 온걸 환영해.");
            Console.WriteLine("가진 건 많이 없지만, 나름 필요한 건 다 있다고 생각해");
            Console.WriteLine("1. 콜라 구매");
            Console.WriteLine("2. 보드카 구매");
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
