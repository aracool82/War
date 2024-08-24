using System.Collections.Generic;
using System;

public class Platoon
{
    private List<SoldierBase> _soldiers;

    public Platoon(List<SoldierBase> solders, string name)
    {
        if (solders == null)
            throw new ArgumentNullException("Ссылка = Null");

        Name = name;
        _soldiers = ReInitSolders(solders);
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

    private List<SoldierBase> ReInitSolders(List<SoldierBase> soldiers)
    {
        List<SoldierBase> newSolders = new List<SoldierBase>();

        foreach (var soldier in soldiers)
            newSolders.Add(soldier.Clone());

        return newSolders;
    }
}