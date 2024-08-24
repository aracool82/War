using System.Collections.Generic;

namespace War
{
    internal class Program
    {
        private static void Main()
        {
            List<SoldierBase> soldiers1 = new List<SoldierBase>() { new EasySoldier(300, 20, 1), new SpecialSoldier(300, 20, 30) };

            Platoon platoon1 = new Platoon(soldiers1);
            Platoon platoon2 = new Platoon(soldiers1);
            VirtualArena virtualArena = new(platoon1, platoon2);

            virtualArena.Fight();
        }
    }
}