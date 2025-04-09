using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public abstract class Item : GameObject
    {
        public Item(string name, string desc) : base(name, desc)
        { }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();
    }
}
