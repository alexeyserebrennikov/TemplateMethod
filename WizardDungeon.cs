using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WizardDungeon : BaseDungeon
    {
        protected override void ChooseHero()
        {
            Console.WriteLine("Выбираем персонажа - мага");
        }

        protected override void AttackMob()
        {
            Console.WriteLine("Наносим магический урон противникам");
        }

        protected override void UseAbilities()
        {
            Console.WriteLine("Используем огненный шар");
        }

        public override string ToString()
        {
            return "Маг";
        }
    }
}
