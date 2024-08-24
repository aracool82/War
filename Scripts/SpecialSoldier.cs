using System.Collections.Generic;

public class SpecialSoldier : SoldierBase
{
    public SpecialSoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
        int maxMultiply = 4;
        int multiply = Assistant.GenerateRandomNumber(maxMultiply, 1);
        Damage *= multiply;
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers != null)
        {
            if (soldiers.Count > 0)
            {
                int randomIndex = Assistant.GenerateRandomNumber(soldiers.Count - 1);
                soldiers[randomIndex].TakeDamage(Damage);
                PrintAttack(this, soldiers[randomIndex]);
            }
        }
    }

    public override SoldierBase Clone()
    {
        return new SpecialSoldier(Health, Damage, Armor);
    }
}