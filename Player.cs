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
        private int maxHealth = 100;
        public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

        private int currentHealth = 100;
        public int CurrentHealth { get { return currentHealth; } set {  currentHealth = value; } }

        private int caps = 100;
        public int Caps { get { return caps; } set { caps = value; } }
        private Inventory inventory = new();
        public Inventory Inventory { get { return inventory; } }
        public List<string> quest = new();
        private Special special = new();
        public Special Special { get { return special; } set { special = value; } }
        public void PrintInfo()
        {
            Console.WriteLine("캐릭터 상태========================");
            special.PrintSpecial();
            Console.WriteLine($"최대 체력: {maxHealth}, 현재 체력: {currentHealth}");
            Console.WriteLine($"현재 돈(캡) : {caps}");
            Console.WriteLine("인벤토리 확인 : I");
            Console.WriteLine("보유 퀘스트------------------------");
            PrintQuest();
            Console.WriteLine("===================================");
        }

        public void PrintQuest()
        {
            if(quest.Count > 0)
            {
                for(int i = 0; i < quest.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {quest[i]}");
                }
            }
            else
            {
                Console.WriteLine("현재 보유한 퀘스트가 없습니다.");
            }
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
