using System.Collections.Generic;

public class MediumSoldier : SoldierBase
{
    public MediumSoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers != null)
        {
            if (soldiers.Count > 0)
            {
                int attackCount = Assistant.GenerateRandomNumber(soldiers.Count);

                for (int i = 0; i < attackCount; i++)
                {
                    soldiers[i].TakeDamage(Damage);
                    PrintAttack(this, soldiers[i]);
                }
            }
        }
    }

    public override SoldierBase Clone()
    {
        return new MediumSoldier(Health, Damage, Armor);
    }
}