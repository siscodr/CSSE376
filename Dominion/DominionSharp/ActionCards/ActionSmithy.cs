﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionSmithy : ActionCard
    {
        public ActionSmithy()
        {
            this.name = "Smithy";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            Console.WriteLine("Smithy Played");
        }
    }
}