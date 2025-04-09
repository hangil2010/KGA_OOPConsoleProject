using OOPConsoleProject.GameObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;
        public List<Item> Items { get { return Items; } }
        private Stack<string> stack;
        private int selectIndex;

        public Inventory() 
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }
        public void Remove(Item item)
        {
            items.Remove(item);
        }
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }
        public void Use(int index)
        {
            items[index].Use();
        }
        // 메뉴창 오픈
        // 스택형식으로 구현
        // 필요 메뉴
        // 1. 메인 인벤토리, 2. 해당 아이템 정보 출력, 3. 해당 아이템 상호작용(각자 아이템에서 해결) 4. 해당 아이템 버리기
        public void Open()
        {
            stack.Push("Menu");
            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "UseItem":
                        UseItem(selectIndex);
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "DropItem":
                        DropItem(selectIndex); 
                        break;
                }
            }
        }

        

        private void Menu() 
        {
            Game.player.PrintInfo();
            PrintItemInfo();

            Console.WriteLine("1. 아이템 사용하기");
            Console.WriteLine("2. 아이템 버리기");
            Console.WriteLine("0 or Backspace. 인벤토리 창 나가기");

            ConsoleKey keyInput = Console.ReadKey(true).Key;
            switch (keyInput)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("아이템 사용 창으로 이동합니다");
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("아이템 버리기 창으로 이동합니다");
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Backspace:
                    Console.WriteLine("인벤토리 창을 종료합니다");
                    stack.Pop();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.ReadKey();
        }
        private void UseMenu()
        {
            Game.player.PrintInfo();
            PrintItemInfo();

            Console.WriteLine("사용할 아이템을 선택해주세요");
            Console.WriteLine("뒤로가기는 BackSpace");
            ConsoleKey keyInput = Console.ReadKey(true).Key;
            if(keyInput == ConsoleKey.Backspace)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)keyInput - (int)ConsoleKey.D1;
                if(select < 0 || items.Count <= select)
                {
                    Console.WriteLine("범위 내 아이템을 선택해주세요");
                    Console.ReadKey();
                }
                else
                {
                    selectIndex = select;
                    
                }
                if (items[selectIndex].IsOneTimeUse == false)
                {
                    Console.WriteLine("해당 아이템은 사용이 불가능합니다");
                }
                else
                {
                    stack.Push("UseItem");
                }
            }
            Console.ReadKey();
        }
        private void UseItem(int index)
        {
            Console.WriteLine($"{items[index].name}을/를 사용합니다.");
            items[index].Use();
            if (items[index].IsOneTimeUse) 
            {
                items.RemoveAt(index);
            }
            Console.ReadKey();
            stack.Pop();
        }
        private void DropMenu()
        {
            Game.player.PrintInfo();
            PrintItemInfo();

            Console.WriteLine("버릴 아이템을 선택해주세요");
            Console.WriteLine("뒤로가기는 BackSpace");
            ConsoleKey keyInput = Console.ReadKey(true).Key;
            if (keyInput == ConsoleKey.Backspace)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)keyInput - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Console.WriteLine("범위 내 아이템을 선택해주세요");
                    Console.ReadKey();
                }
                else
                {
                    selectIndex = select;
                    stack.Push("DropItem");
                }
            }
        }
        private void DropItem(int index) 
        {
            Console.WriteLine($"{items[index].name}을/를 버립니다.");
                items.RemoveAt(index);
            Console.ReadKey();
            stack.Pop();
        }
        public void PrintItemInfo() 
        {
            Console.WriteLine("---현재 인벤토리 정보---");
            if(items.Count == 0)
            {
                Console.WriteLine("인벤토리가 비어있습니다");
            }
            else
            {
                for(int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i+1}. 이름 : {items[i].name} \t설명 : {items[i].desc}");
                }
            }
            Console.WriteLine("------------------------");
        }
    }
}
