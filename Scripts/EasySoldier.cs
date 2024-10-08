﻿using System.Collections.Generic;

public class EasySoldier : SoldierBase
{
    public EasySoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers == null)
            return;

        if (soldiers.Count == 0)
            return;

        int randomIndex = Assistant.GenerateRandomNumber(soldiers.Count);
        soldiers[randomIndex].TakeDamage(Damage);
        PrintAttack(soldiers[randomIndex]);
    }

    public override SoldierBase Clone()
    {
        return new EasySoldier(Health, Damage, Armor);
    }
}