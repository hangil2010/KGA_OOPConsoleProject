using OOPConsoleProject.GameObject;
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
        public Drink drink = new Drink("콜라", "체력을 30 회복시켜줍니다.");

        public override void Render()
        {
            Game.player.PrintInfo();
            // 캐릭터 생성할때랑 아닐때 다른 대사가 나오게 함
            // 피해를 입었을 때 또 다른 대사가 나오게 한다.
            if (!Game.progess[0]) 
            {
                //Util.Print("이정도면 충분하네, 움직일 수 있는걸 보니 다행이군\n");
                //Util.Print("나중에 돌아다니다가 다치거나 하면 바로 오게나\n");
                //Util.Print("내가 치료할 수 있다면 치료 해주지\n");
                //Util.Print("마을 동쪽에 트루디의 술집이 있을걸세, 그 난리를 겪고 나면 술 한잔이 생각날껄세\n");
                //Util.Print("크게 갈 곳이 없다면 그곳을 가 보는 것도 좋겠네.\n");
                Console.WriteLine("이정도면 충분하네, 움직일 수 있는걸 보니 다행이군");
                Console.WriteLine("나중에 돌아다니다가 다치거나 하면 바로 오게나");
                Console.WriteLine("내가 치료할 수 있다면 치료 해주지");
                Console.WriteLine("마을 동쪽에 트루디의 술집이 있을걸세, 그 난리를 겪고 나면 술 한잔이 생각날껄세");
                Console.WriteLine("크게 갈 곳이 없다면 그곳을 가 보는 것도 좋겠네.");
                Console.WriteLine("무사히 일어났으니 단 게 먹고 싶을 걸세, 여기 냉장고에 하나 가져가게");
                Game.player.Inventory.Add(drink);
                Console.WriteLine("그리고 어디 물건 살때 필요할 캡도 좀 주겠네");
                Game.player.Caps += 100;
            }
            else
            {
                
                if(Game.player.CurrentHealth < Game.player.MaxHealth)
                {
                    Console.WriteLine("좀 다쳤나 보군, 치료가 필요한가?");
                }
                else
                {
                    Console.WriteLine("건강하게 잘 지내는걸 보니 다행이군.");
                }
            }
            Console.WriteLine("마을 밖으로 나간다");
            Console.WriteLine("아무 키나 눌러 진행");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            // 캐릭터 생성이 완료됬으니 true로 변경
            Game.progess[0] = true;
            if(input == ConsoleKey.I)
            {
                Game.player.Inventory.Open();
            }
            else 
            { 
                Game.ChangeScene("TownNorth");
            }
        }

        public override void Update()
        {
        }
    }
}
