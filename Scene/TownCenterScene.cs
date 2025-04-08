namespace OOPConsoleProject.Scene
{
    internal class TownCenterScene : BaseScene
    {
        public TownCenterScene() { name = "TownCenter"; }
        public override void Render()
        {
            Console.WriteLine("굿 스프링스 마을 중심지");
            Console.WriteLine("N : 북쪽으로 가기");
            Console.WriteLine("S : 남쪽으로 가기");
            Console.WriteLine("E : 동쪽으로 가기");
            Console.WriteLine("W : 서쪽으로 가기");
        }

        public override void Input()
        {
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.N:
                    Console.WriteLine("마을 북쪽으로 갑니다");
                    Game.ChangeScene("TownNorth");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("마을 남쪽으로 갑니다");
                    Game.ChangeScene("TownSouth");
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("마을 동쪽으로 갑니다");
                    Game.ChangeScene("TownEast");
                    break;
                case ConsoleKey.W:
                    Console.WriteLine("마을 서쪽으로 갑니다");
                    Game.ChangeScene("TownWest");
                    break;
                default:
                    Console.WriteLine("잘못된 키를 입력하셨습니다");
                    break;
            }
        }

        public override void Update()
        {

        }
    }
}
