using System.Collections.Generic;

namespace War;

internal class Program
{
    private static void Main()
    {
        Platoon platoon1 = new Platoon("Чебурашкеры");
        Platoon platoon2 = new Platoon( "Крокодиллеры");
        VirtualArena virtualArena = new(platoon1, platoon2);

        virtualArena.Fight();
    }
}