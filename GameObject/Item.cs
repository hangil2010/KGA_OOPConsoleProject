using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public abstract class Item : GameObject
    {
        // 1회용 아이템 ( 소모품 ) 인 경우를 생각해서 bool 타입 추가
        // 자식클래스에서 결정할 수 있게 protected 접근자로 설정
        protected bool isOneTimeUse;
        public bool IsOneTimeUse { get { return isOneTimeUse; } }
        public Item(string name, string desc) : base(name, desc)
        {
        }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();
    }
}
