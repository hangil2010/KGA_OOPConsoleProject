﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    internal class SallonScene : BaseScene
    {
        public SallonScene() { name = "Sallon"; }
        

        public override void Render()
        {
            Console.WriteLine("탄광꾼의 술집에 들어간다");
        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Result()
        {
            Game.ChangeScene("TownEast");
        }

        public override void Update()
        {

        }
    }
}
