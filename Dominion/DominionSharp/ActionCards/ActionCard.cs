﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public abstract class ActionCard : Card
    {
        public abstract void play();
    }
}