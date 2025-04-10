using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Special
    {
        private int strength = 1;
        public int Strength { get { return strength; } set { strength = value; } }
        private int percepction = 1;
        public int Percepction { get { return percepction; } set { percepction = value; } }

        private int endurance = 1;
        public int Endurance { get { return endurance; } set { endurance = value; } }

        private int charisma = 1;
        public int Charisma { get { return charisma; } set { charisma = value; } }

        private int intelligence = 1;
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        private int agility = 1;
        public int Agility { get { return agility; } set { agility = value; } }

        private int luck = 1;
        public int Luck { get { return luck; } set { luck = value; } }
        private int specialPoints = 45;
        public int SpecialPoints { get { return specialPoints; } }
        public void SetSpecial()
        {
            PrintSpecial();
            Console.WriteLine("Strength, 줄여서 STR는 근접 무기 피해량과 인벤토리 크기에 관여합니다");
            Console.WriteLine("특정 무기는 일정 STR를 넘겨야 착용이 가능합니다");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            strength += Util.IntInput(1, 9);
            specialPoints -= strength;
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Perception, 줄여서 PER는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 적을 더 멀리서 맞출 수 있습니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            percepction += Util.IntInput(1, 9);
            specialPoints -= percepction;
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Endurance, 줄여서 END는 내구성에 관여합니다");
            Console.WriteLine("능력치를 높일수록 방어력이 증가합니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            endurance += Util.IntInput(1, 9);
            specialPoints -= endurance;
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Charisma, 줄여서 CHA는 사람들과 대화 및 거래 능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 대화에서 이점을 챙길 수 있습니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            if (specialPoints > 0)
            {
                if (specialPoints < 10)
                {
                    int limit = specialPoints;
                    charisma += Util.IntInput(1, limit);
                    specialPoints -= charisma;
                }
                else
                {
                    charisma += Util.IntInput(1, 9);
                    specialPoints -= charisma;
                }
            }
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Intelligence, 줄여서 INT는 경험치와 레벨업때 획득할 능력치에 관여합니다");
            Console.WriteLine("능력치를 높일수록 레벨을 더 빨리 업할 수 있습니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            if (specialPoints > 0)
            {
                if (specialPoints < 10)
                {
                    int limit = specialPoints;
                    intelligence += Util.IntInput(1, limit);
                    specialPoints -= intelligence;
                }
                else
                {
                    intelligence += Util.IntInput(1, 9);
                    specialPoints -= intelligence;
                }
            }
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Agility, 줄여서 AGL는 플레이어의 이동능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 더 빠르게 움직일 수 있습니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            if (specialPoints > 0)
            {
                if (specialPoints < 10)
                {
                    int limit = specialPoints;
                    agility += Util.IntInput(1, limit);
                    specialPoints -= agility;
                }
                else
                {
                    agility += Util.IntInput(1, 9);
                    specialPoints -= agility;
                }
            }
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Luck, 줄여서 LUK는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 운이 더 좋아집니다.");
            Console.WriteLine($"남은 능력치 설정 가능 수치 : {specialPoints}");
            if (specialPoints > 0)
            {
                if (specialPoints < 10)
                {
                    int limit = specialPoints;
                    luck += Util.IntInput(1, limit);
                    specialPoints -= luck;
                }
                else
                {
                    luck += Util.IntInput(1, 9);
                    specialPoints -= luck;
                }
            }
            Console.Clear();

            SetLeftOvers();

            Console.WriteLine("최종 능력치");
            PrintSpecial();
            Console.WriteLine("현재 능력치에 만족하십니까? Y / N");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("진행합니다");
                    break;
                case ConsoleKey.N:
                    Console.Clear();
                    Console.WriteLine("캐릭터 생성을 다시 진행합니다.");
                    specialPoints = 45;
                    strength = 1;
                    percepction = 1;
                    endurance = 1;
                    charisma = 1;
                    intelligence = 1;
                    agility = 1;
                    luck = 1;
                    SetSpecial();
                    break;
                default:
                    Console.WriteLine("잘못 입력하였습니다");
                    break;
            }
        }
        private void SetLeftOvers()
        {
            int leftovers = 0;
            while (specialPoints > 0)
            {
                Console.Clear();
                PrintSpecial();
                Console.WriteLine($"아직 능력치 설정을 {specialPoints}만큼 가능합니다. 어느 능력치에 햘당하겠습니까?");
                // 올릴 능력치 대상을 받는다
                Console.WriteLine("1. STR, 2. PER, 3. END, 4. CHR, 5. INT, 6. AGL, 7. LUK");
                switch (Util.IntInput(1, 7))
                {
                    // 1. 능력치가 10 이면 능력치 추가를 하지 않음
                    // 2. 능력치가 10 이하인 경우
                    // 2-1. 남은 스페셜 포인트가 그 차이만큼 채울 수 있는 경우
                    // -그 차이만큼의 값을 받고 뺀다.
                    // 2-2. 남은 스페셜 포인트가 그 차이를 채울 수 없는 경우
                    // -남은 스페셜 포인트를 전부 그 능력치에 부여함
                    case 1:
                        Console.WriteLine("STR를 증가시킵니다.");
                        if (strength < 10) 
                        {
                            if (strength + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - strength);
                                strength += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                strength += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("PER를 증가시킵니다");
                        if (percepction >= 10) { }
                        else
                        {
                            if (percepction + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - percepction);
                                percepction += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                percepction += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("END를 증가시킵니다.");
                        if (endurance >= 10) { }
                        else
                        {
                            if (endurance + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - endurance);
                                endurance += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                endurance += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("CHR를 증가시킵니다.");
                        if (charisma >= 10) { }
                        else
                        {
                            if (charisma + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - charisma);
                                charisma += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                charisma += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("INT를 증가시킵니다.");
                        if (intelligence >= 10) { }
                        else
                        {
                            if (intelligence + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - intelligence);
                                intelligence += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                intelligence += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("AGL를 증가시킵니다");
                        if (agility >= 10) { }
                        else
                        {
                            if (agility + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - agility);
                                agility += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                agility += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("LUK를 증가시킵니다");
                        if (luck >= 10) { }
                        else
                        {
                            if (luck + specialPoints >= 10)
                            {
                                leftovers = Util.IntInput(1, 10 - luck);
                                luck += leftovers;
                                specialPoints -= leftovers;
                            }
                            else
                            {
                                luck += Util.IntInput(1, specialPoints);
                                specialPoints -= specialPoints;
                            }
                        }
                        break;
                }
                // 해당 능력치가 10이 아닌지 체크한다
                // 10이 아닐경우 1부터 합이 10이 되는 값 이하의 값을 받아 더한다.
            }
        }
        public void PrintSpecial()
        {
            Console.WriteLine($"힘: {strength} 감각: {percepction} 근성: {endurance} 매력: {charisma} 지능: {intelligence} 민첩: {agility} 행운: {luck}");
        }
    }
}
