using OOPConsoleProject.GameObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;
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
                    case "DropItem":
                        DropItem(); 
                        break;
                }
            }
        }

        

        private void Menu() 
        {
            PrintItemInfo();

            Console.WriteLine("1. 아이템 사용하기");
            Console.WriteLine("2. 아이템 버리기");
            Console.WriteLine("0 or Backspace. 아이템 화면 나가기");

            ConsoleKey keyInput = Console.ReadKey(true).Key;
            switch (keyInput)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Backspace:
                    stack.Pop();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
        private void UseMenu()
        {
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
                    stack.Push("UseItem");
                }
            }
        }
        private void UseItem(int index)
        {
            items[index].Use();
        }
        private void DropItem() { }
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
                    Console.WriteLine($"{i+1}, 이름 : {items[i].name}, 설명 : {items[i].desc}");
                }
            }
            Console.WriteLine("------------------------");
        }
    }
}
