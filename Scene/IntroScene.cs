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
            //Util.Print("200년 전 핵 전쟁으로 페허가 된 세계...\n");
            //Util.Print("당신은 모하비 지부의 배달부로써 매일매일 살아가고 있었다.\n");
            //Util.Print("그러나 어느 날 Mr.House라는 한 부자가 플래티넘 칩이라는 특이한 물품을 배달해달라고 부탁했다.\n");
            //Util.Print("그때 당신은 몰랐다.. 그 칩이 어떤 일을 불러올지\n");
            
            //Util.Print("예정대로 배달을 진행하던 도중, 굿 스프링스에서 기습을 당하였다.\n");
            //Util.Print("정신을 차려보니, 어느 흰 체크무늬 남성과 두 부하가 앞에 있었다.\n");
            //Util.Print("손과 입은 천으로 단단히 묶여있었다. 주변을 둘러보니 공동묘지였다...\n\n");

            //Util.Print("흰 체크무니 남성", backColor: ConsoleColor.White, textColor : ConsoleColor.Black, delay : 0);
            //Util.Print(" : 이게 플래티넘 칩이군, 이것만 있다면...\n");
            //Util.Print("붉은 머리를 한 부하", textColor: ConsoleColor.Red, delay : 0);
            //Util.Print(" : 대장, 이놈 깨어났는가 본데요?\n");

            //Util.Print("금발 머리를 한 부하", textColor: ConsoleColor.Yellow, delay : 0);
            //Util.Print(" : 칩을 얻엇으니 빨리 떠나죠, 악령을 깨우고 싶지는 않아요\n");

            //Util.Print("흰 체크무니 남성", backColor: ConsoleColor.White, textColor: ConsoleColor.Black, delay: 0);
            //Util.Print(" : 아 드디어 일어났군 배달부\n");

            //Util.Print("흰 체크무니 남성", backColor: ConsoleColor.White, textColor: ConsoleColor.Black, delay: 0);
            //Util.Print(" : 참 신기하단 말이야, 도통 움직이지 않던 사람이 이런걸 배달시키고\n");

            //Util.Print("흰 체크무니 남성", backColor: ConsoleColor.White, textColor: ConsoleColor.Black, delay: 0);
            //Util.Print(" : 지금 생각하고 있을꺼야, '왜 하필 나지' 라고\n");

            //Util.Print("흰 체크무니 남성은 나에게 총을 겨누면서 말했다.\n");

            //Util.Print("흰 체크무니 남성", backColor: ConsoleColor.White, textColor: ConsoleColor.Black, delay: 0);
            //Util.Print(" : 진실을 말해주자면, 게임은 시작부터 조작되어 있었어.\n", delay: 3000);

            //Util.Print("탕.\n\n", textColor : ConsoleColor.Red, delay : 5000);
            //Console.Clear();
            //Util.Print("정신이 혼미해지던 도중 무언가에 실려가는 느낌이 들었다\n");
            //Util.Print("??? : 정신차려 파트너, 곧 의사한테 데려가 줄께\n\n");
            //Util.Print("정신을 차려보니 어떤 중년 남성이 나를 지켜보고 있었다\n");
            //Util.Print("??? : 깨어났군, 살아남은 것도 기적인데 멀쩡하게 일어났는군\n");
            //Util.Print("미첼", textColor: ConsoleColor.DarkBlue, delay: 0);
            //Util.Print(" : 나 자신을 소개하지, 이름은 미첼이라고 해, 굿 스프링스의 의사지\n");

            //Util.Print("총성이 들려서 빅터보고 그쪽에 가서 생존자가 있는지 조사해달라고 했고 기적적으로 너를 찾아냈네.\n");
            //Util.Print("몸을 확인해보니 머리에 총상을 입었고, 기적적으로 목숨을 붙이고는 있어서 수술을 진행했다네.\n");
            //Util.Print("마을에서 나가기 전에 몸 상태에 대해 간단한 검진만 하면 된다네.\n");
            Util.Print("실험의 목적은 아니고, 너 몸 상태를 기록만 해둘려고 해, 혹여나 다시 올 때를 대비해서\n", delay : 0);
            Console.WriteLine("============================================");
            Console.WriteLine("아무 키나 눌러 진행...");
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
