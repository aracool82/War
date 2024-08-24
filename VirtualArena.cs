using System;

public class VirtualArena
{
    private Platoon _platoon1;
    private Platoon _platoon2;

    public VirtualArena(Platoon platoon1, Platoon platoon2)
    {
        if (platoon1 == platoon2)
            throw new Exception("Одинаковые ссылки");

        _platoon1 = platoon1;
        _platoon2 = platoon2;
    }

    public void ShowInfo()
    {
        Console.WriteLine("[1]");
        _platoon1.ShowInfo();

        Console.WriteLine("[2]");
        _platoon2.ShowInfo();

        Console.ReadKey();
        Console.Clear();
    }

    public void Fight()
    {
        while (_platoon1.IsAlive && _platoon2.IsAlive)
        {
            ShowInfo();
            _platoon1.Attack(_platoon2);
            _platoon2.Attack(_platoon1);
            ShowInfo();
        }

        if (_platoon1.IsAlive && _platoon2.IsAlive == false)
            Console.WriteLine($"Победил взвод 1 {_platoon1.Name}");
        else if (_platoon2.IsAlive && _platoon1.IsAlive == false)
            Console.WriteLine($"Победил взвод 2 {_platoon2.Name}");
        else if (_platoon2.IsAlive == false && _platoon1.IsAlive == false)
            Console.WriteLine("Ничья");
    }
}
