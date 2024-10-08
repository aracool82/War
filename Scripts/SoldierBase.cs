﻿using System.Collections.Generic;
using System;

public abstract class SoldierBase
{
    public SoldierBase(int health, int damage, int armor)
    {
        if (health < 0)
            throw new IndexOutOfRangeException("health < 0");

        if (damage < 0)
            throw new IndexOutOfRangeException("damage < 0");

        if (armor < 0)
            throw new IndexOutOfRangeException("armor < 0");

        Health = health;
        Damage = damage;
        Armor = armor;
    }

    public int Health { get; protected set; }
    public int Damage { get; protected set; }
    public int Armor { get; protected set; }

    public bool IsAlive => Health > 0;

    public abstract void Attack(List<SoldierBase> solders);

    public void TakeDamage(int amount)
    {
        if (IsAlive)
            Health -= amount - Armor;
    }

    public abstract SoldierBase Clone();

    protected void PrintAttack(SoldierBase target)
    {
        Console.WriteLine($"Атакующий : {GetType().Name}");
        Console.WriteLine($"Жизнь - {Health}  Дамаг {Damage} Броня {Armor}\n");
        
        Console.WriteLine($"{GetType().Name} ---> {target.GetType().Name}");
    }
}