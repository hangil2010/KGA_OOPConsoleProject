using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Player
    {
        private int strength = 8;
        public int Strength { get { return strength; } set { strength = value; } }
        private int percepction = 0;
        public int Percepction { get { return percepction; } set { percepction = value; } }

        private int endurance = 8;
        public int Endurance { get { return endurance; } set { endurance = value; } }

        private int charisma = 8;
        public int Charisma { get { return charisma; } set { charisma = value; } }

        private int intelligence = 8;
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        private int agility = 0;
        public int Agility { get { return agility; } set { agility = value; } }

        private int luck = 0;
        public int Luck { get { return luck; } set { luck = value; } }

        private int maxHealth = 100;
        public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

        private int currentHealth;
        public int CurrentHealth { get { return currentHealth; } set {  currentHealth = value; } }

        private int caps = 100;
        public int Caps { get { return caps; } set { caps = value; } }
        private Inventory inventory = new();
        public Inventory Inventory { get { return inventory; } }
        public void PrintInfo()
        {
            Console.WriteLine("===================================");
            PrintSpecial();
            Console.WriteLine($"현재 돈 : {caps}");
            inventory.PrintItemInfo();
            Console.WriteLine("===================================");
        }

        public void SetSpecial()
        {
            Console.WriteLine("Strength, 줄여서 STR는 근접 무기 피해량과 인벤토리 크기에 관여합니다");
            Console.WriteLine("특정 무기는 일정 STR를 넘겨야 착용이 가능합니다");
            strength = Util.IntInput(1, 10);
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Perception, 줄여서 PER는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 적을 더 멀리서 맞출 수 있습니다.");
            percepction = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Endurance, 줄여서 END는 최대 체력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 체력이 증가합니다.");
            endurance = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Charisma, 줄여서 CHA는 사람들과 대화 및 거래 능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 대화에서 이점을 챙길 수 있습니다.");
            charisma = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Intelligence, 줄여서 INT는 경험치와 레벨업때 획득할 능력치에 관여합니다");
            Console.WriteLine("능력치를 높일수록 레벨을 더 빨리 업할 수 있습니다.");
            intelligence = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Agility, 줄여서 AGL는 플레이어의 이동능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 더 빠르게 움직일 수 있습니다.");
            agility = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Luck, 줄여서 LUK는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 운이 더 좋아집니다.");
            luck = Util.IntInput(1, 10);

            Console.Clear();
            Console.WriteLine("최종 능력치");
            PrintSpecial();
            maxHealth += endurance * 10;
            currentHealth = maxHealth;
        }
        public void PrintSpecial()
        {
            Console.WriteLine($"힘 : {strength}, 감각 : {percepction}, 근성 : {endurance}, 매력 : {charisma}, 지능 : {intelligence}, 민첩 : {agility}, 행운 : {luck}");
            Console.WriteLine($"최대 체력 : {maxHealth}, 현재 체력 : {currentHealth}");
        }

        public void Heal(int healAmount)
        {
            currentHealth += healAmount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }
}
