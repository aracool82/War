using System.Collections.Generic;
using System;

public class Platoon
{
    private List<SoldierBase> _soldiers = new List<SoldierBase>();
    private SoldierFabrick _soldierFabrick = new SoldierFabrick();

    public Platoon(string name)
    {
        Name = name;

        _soldiers.Add(_soldierFabrick.CreateEasySolder());
        _soldiers.Add(_soldierFabrick.CreateSpecialSoldier());
        _soldiers.Add(_soldierFabrick.CreateMediumSoldier());
        _soldiers.Add(_soldierFabrick.CreateHardSoldier());
    }

    public string Name { get; private set; }
    public bool IsAlive => _soldiers.Count > 0;

    public void ShowInfo()
    {
        string state = IsAlive == true ? "Жив" : "Мертв";

        Console.WriteLine($"Взвод <{Name}>\nСтатус        -  {state} \n" +
                          $"Живые солдаты -  {_soldiers.Count}\n");
    }

    public void Attack(Platoon opponentPlatoon)
    {
        if (opponentPlatoon != null)
        {
            RemoveDeadSolder();

            if (IsAlive)
            {
                if (opponentPlatoon.TryGetSolders(out List<SoldierBase> opponentSolders))
                {
                    for (int i = 0; i < _soldiers.Count; i++)
                    {
                        _soldiers[i].Attack(opponentSolders);
                        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
                    }
                }
            }
        }
    }

    private void RemoveDeadSolder()
    {
        if (_soldiers != null)
            if (_soldiers.Count > 0)
                for (int i = 0; i < _soldiers.Count; i++)
                    if (_soldiers[i].IsAlive == false)
                        _soldiers.Remove(_soldiers[i]);
    }

    private bool TryGetSolders(out List<SoldierBase> soldiers)
    {
        if (IsAlive)
        {
            soldiers = _soldiers;
            return true;
        }

        soldiers = null;
        return false;
    }
}