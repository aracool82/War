﻿using System.Collections.Generic;

public class SpecialSoldier : SoldierBase
{
    public SpecialSoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
        int maxMultiply = 3;
        int multiply = Assistant.GenerateRandomNumber(maxMultiply, 1);
        Damage *= multiply;
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers == null)
            return;

        if (soldiers.Count == 0)
            return;

        int randomIndex = Assistant.GenerateRandomNumber(soldiers.Count - 1);
        soldiers[randomIndex].TakeDamage(Damage);
        PrintAttack(soldiers[randomIndex]);
    }

    public override SoldierBase Clone()
    {
        return new SpecialSoldier(Health, Damage, Armor);
    }
}