using System.Collections.Generic;

public class HardSoldier : SoldierBase
{
    public HardSoldier(int health, int damage, int armor) : base(health, damage, armor)
    {
    }

    public override void Attack(List<SoldierBase> soldiers)
    {
        if (soldiers == null)
            return;

        if (soldiers.Count == 0)
            return;

        int attackCount = Assistant.GenerateRandomNumber(1,soldiers.Count);

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

    public override SoldierBase Clone()
    {
        return new HardSoldier(Health, Damage, Armor);
    }
}