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
            Game.player.PrintInfo();
            if (!Game.progess[0]) 
            { 
                //Util.Print("이정도면 충분하네, 움직일 수 있는걸 보니 다행이군\n");
                //Util.Print("나중에 돌아다니다가 다치거나 하면 바로 오게나\n");
                //Util.Print("내가 치료할 수 있다면 치료 해주지\n");
                //Util.Print("마을 동쪽에 트루디의 술집이 있을걸세, 그 난리를 겪고 나면 술 한잔이 생각날껄세\n");
                //Util.Print("크게 갈 곳이 없다면 그곳을 가 보는 것도 좋겠네.\n");
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
            Console.ReadKey(true);
        }
        public override void Result()
        {
            Game.ChangeScene("TownNorth");
        }

        public override void Update()
        {
            Game.progess[0] = true;
        }
    }
}
