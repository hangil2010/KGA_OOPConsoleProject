using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public class Drink : Item
    {
        private int heal;
        public Drink(string name, string desc, int heal) : base(name, desc)
        {
            this.heal = heal;
        }

        public override void Use()
        {
            Game.player.Heal(heal);
        }
    }
}
