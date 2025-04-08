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
            Game.player.PrintStat();
            if (!Game.gameProgess[0]) 
            { 
                Util.Print("이정도면 충분하네, 움직일 수 있는걸 보니 다행이군\n");
                Util.Print("나중에 돌아다니다가 다치거나 하면 바로 오게나\n", delay: 0);
                Util.Print("내가 치료할 수 있다면 치료 해주지\n");
                Util.Print("마을 동쪽에 트루디의 술집이 있을걸세, 그 난리를 겪고 나면 술 한잔이 생각날껄세\n");
                Util.Print("크게 갈 곳이 없다면 그곳을 가 보는 것도 좋겠네.\n");
            }
            else
            {
                Util.Print("다시 왔네, 반갑다\n");
            }
            Console.WriteLine("마을 밖으로 나간다");
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
            Game.gameProgess[0] = true;
        }
    }
}
