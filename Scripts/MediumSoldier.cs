using System.Collections.Generic;

public class MediumSoldier : SoldierBase
{
    public MediumSoldier(int health, int damage, int armor) : base(health, damage, armor)
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
            soldiers[i].TakeDamage(Damage);
            PrintAttack(soldiers[i]);
        }
    }

    public override SoldierBase Clone()
    {
        return new MediumSoldier(Health, Damage, Armor);
    }
}