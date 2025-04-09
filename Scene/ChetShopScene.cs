using OOPConsoleProject.GameObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class ChetShopScene : BaseScene
    {
        public ChetShopScene() { name = "ChetShop"; }
        private Drink cider = new Drink("사이다", "체력을 30 회복시켜줍니다", 30);
        private Drink wiskey = new Drink("위스키", "체력을 50 회복시켜줍니다", 50);
        public override void Render()
        {
            if(Game.player.quest.Contains("챗의 상점으로 가보자"))
            {
                Game.player.quest.Remove("챗의 상점으로 가보자");
            }
            Game.player.PrintInfo();
            Util.Print("쳇 : 내 상점에 온걸 환영해.");
            Util.Print("가진 건 많이 없지만, 나름 필요한 건 다 있다고 생각해");
            Console.WriteLine("1. 사이다 구매, 가격 : 100 캡");
            Console.WriteLine("2. 위스키 구매, 가격 : 150 캡");
            Console.WriteLine("E. 마을 동쪽으로 돌아갑니다.");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            if(input != ConsoleKey.I)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        if(Game.player.Caps >= 100)
                        {
                            Console.WriteLine("사이다 하나 대령합니다");
                            Game.player.Caps -= 100;
                            Game.player.Inventory.Add(cider);
                        }
                        else
                        {
                            Console.WriteLine("돈이 없는 거 같은데? 돈을 좀 모아서 와");
                        }
                        break;
                    case ConsoleKey.D2:
                        if (Game.player.Caps >= 150)
                        {
                            Console.WriteLine("위스키 하나 대령합니다");
                            Game.player.Caps -= 150;
                            Game.player.Inventory.Add(cider);
                        }
                        else
                        {
                            Console.WriteLine("돈이 없는 거 같은데? 돈을 좀 모아서 와");
                        }
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("마을 동쪽으로 이동합니다");
                        Game.ChangeScene("TownEast");
                        break;
                }
                Console.ReadKey();
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
