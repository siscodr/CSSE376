﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionChapel:ActionCard
    {
        public ActionChapel()
        {
            this.name = "Chapel";
            this.cost = 2;
            this.picture = global::DominionSharp.Properties.Resources.chapel;
            this.trashes = 4;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Chapel Played");
            createForm();
        }
        protected virtual void createForm()
        {
            FormTrash ft = new FormTrash(Turn.Instance.getActivePlayer(), this.trashes);
            ft.ShowDialog();
        }
    }
}
