using System.Collections.Generic;

public class HardSoldier : SoldierBase
{
    public HardSoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers != null)
        {
            if (soldiers.Count > 0)
            {
                int attackCount = Assistant.GenerateRandomNumber(soldiers.Count,1);

                for (int i = 0; i < attackCount; i++)
                {
                    int randomIndex = Assistant.GenerateRandomNumber(soldiers.Count);

                    if (soldiers[randomIndex].IsAlive)
                    { 
                        soldiers[randomIndex].TakeDamage(Damage);
                        PrintAttack(soldiers[randomIndex]);
                    }

                }
            }
        }
    }

    public override SoldierBase Clone()
    {
        return new HardSoldier(Health, Damage, Armor);
    }
}