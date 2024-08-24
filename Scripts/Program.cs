using System.Collections.Generic;

namespace War;

internal class Program
{
    private static void Main()
    {
        List<SoldierBase> soldiers1 = new List<SoldierBase>() { new EasySoldier(250, 50, 1), new SpecialSoldier(300, 35, 15) };
        List<SoldierBase> soldiers2 = new List<SoldierBase>() { new EasySoldier(500, 20, 1), new SpecialSoldier(300, 40, 5) };

        Platoon platoon1 = new Platoon(soldiers1,"Чебурашкеры");
        Platoon platoon2 = new Platoon(soldiers1, "Крокодиллеры");
        VirtualArena virtualArena = new(platoon1, platoon2);

        virtualArena.Fight();
    }
}