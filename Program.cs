using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var warriorDungeon = new WarriorDungeon();
            var wizardDungeon = new WizardDungeon();

            //отправляем война в данж
            Console.WriteLine(warriorDungeon);
            warriorDungeon.Expedition();
            Console.ReadLine();

            //отправляем мага в данж
            Console.WriteLine(wizardDungeon);
            wizardDungeon.Expedition();
            Console.ReadLine();
        }
    }
}








