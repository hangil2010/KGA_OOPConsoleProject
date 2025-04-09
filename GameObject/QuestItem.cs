using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    internal class QuestItem : Item
    {
        public QuestItem(string name, string desc) : base(name, desc)
        {
            isOneTimeUse = false;
        }

        public override void Use()
        {
        }
    }
}
