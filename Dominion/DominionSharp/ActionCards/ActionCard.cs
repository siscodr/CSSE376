﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public abstract class ActionCard : Card
    {
        protected int actions = 0;
        protected int buys = 0;
        protected int cards = 0;
        protected int coins = 0;
        protected int trashes = 0;

        public int Actions
        {
            get
            {
                return actions;
            }
        }

        public int Buys
        {
            get
            {
                return buys;
            }
        }

        public int Cards
        {
            get
            {
                return cards;
            }
        }

        public int Coins
        {
            get
            {
                return coins;
            }
        }

        public int Trashes
        {
            get
            {
                return trashes;
            }
        }

        public override void play()
        {
            Turn.Instance.setBuys(this.buys + Turn.Instance.getBuys());
            Turn.Instance.setActions(this.actions + Turn.Instance.getActions());
            Turn.Instance.setCoins(this.coins + Turn.Instance.getCoins());
            Turn.Instance.setTrashes(this.trashes + Turn.Instance.getTrashes());
        }
    }
}
