using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WarriorDungeon : BaseDungeon
    {
        protected override void ChooseHero()
        {
            Console.WriteLine("Выбираем персонажа - воина");
        }

        protected override void AttackMob()
        {
            Console.WriteLine("Наносим физический урон противникам мечом");
        }

        protected override void UseAbilities()
        {
            Console.WriteLine("Используем удар щитом");
        }

        public override string ToString()
        {
            return "Воин";
        }
    }
}
