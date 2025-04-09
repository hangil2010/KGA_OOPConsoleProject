namespace OOPConsoleProject.Scene
{
    internal class TownCenterScene : BaseScene
    {
        public TownCenterScene() { name = "TownCenter"; }
        public override void Render()
        {
            Game.player.PrintInfo();
            Console.WriteLine("굿 스프링스 마을 중심지이다.");
            Console.WriteLine("N : 북쪽으로 가기");
            Console.WriteLine("S : 남쪽으로 가기");
            Console.WriteLine("E : 동쪽으로 가기");
            Console.WriteLine("W : 서쪽으로 가기");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Result()
        {
            string targetScene = "";
            switch (input)
            {
                case ConsoleKey.N:
                    Console.WriteLine("마을 북쪽으로 갑니다");
                    targetScene = "TownNorth";
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("마을 남쪽으로 갑니다");
                    targetScene = "TownSouth";
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("마을 동쪽으로 갑니다");
                    targetScene = "TownEast";
                    break;
                case ConsoleKey.W:
                    Console.WriteLine("마을 서쪽으로 갑니다");
                    targetScene = "TownWest";
                    break;
                default:
                    Console.WriteLine("잘못된 키를 입력하셨습니다");
                    break;
            }
            Console.ReadKey();
            if(targetScene != "")
            {
                Game.ChangeScene(targetScene);
            }
        }

        public override void Update()
        {

        }
    }
}
