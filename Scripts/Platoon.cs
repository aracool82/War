using System.Collections.Generic;
using System;

public class Platoon
{
    private List<SoldierBase> _soldiers = new List<SoldierBase>();

    private EasySoldierFabrick _easySoldierFabrick = new EasySoldierFabrick();
    private SpecialSoldierFabrick _specialSoldierFabrick = new SpecialSoldierFabrick();
    private MediumSoldierFabrick mediumSoldierFabrick = new MediumSoldierFabrick();
    private HardSoldierFabrick _hardSoldierFabrick = new HardSoldierFabrick();

    public Platoon(string name)
    {
        Name = name;

        _soldiers.Add(_easySoldierFabrick.Create());
        _soldiers.Add(_specialSoldierFabrick.Create());
        _soldiers.Add(mediumSoldierFabrick.Create());
        _soldiers.Add(_hardSoldierFabrick.Create());
    }

    public List<SoldierBase> Soldiers => new List<SoldierBase>(_soldiers);

    public string Name { get; private set; }
    public bool IsAlive => _soldiers.Count > 0;

    public void ShowInfo()
    {
        string state = _soldiers.Count > 0 ? "Жив" : "Мертв";

        Console.WriteLine($"Взвод <{Name}>\nСтатус        -  {state} \n" +
                          $"Живые солдаты -  {_soldiers.Count}\n");
    }

    public void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers == null)
            return;

        if (IsAlive)
        {
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < _soldiers.Count; i++)
                _soldiers[i].Attack(soldiers);
        }
    }

    public void RemoveDeadSolder()
    {
        if (_soldiers == null)
            return;

        if (_soldiers.Count == 0)
            return;

        for (int i = 0; i < _soldiers.Count; i++)
            if (_soldiers[i].IsAlive == false)
                _soldiers.Remove(_soldiers[i]);
    }
}