using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public abstract class BaseDungeon
    {
        public void Expedition()
        {
            ChooseHero();
            AttackMob();
            UseAbilities();
        }

        protected abstract void ChooseHero();

        protected abstract void AttackMob();

        protected abstract void UseAbilities();
    }
}
