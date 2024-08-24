public abstract class SoldierBaseFactory
{
    public abstract SoldierBase Create();

    protected int GenerateHealth()
    {
        int maxHealth = 300;
        int minHealth = 200;
        return Assistant.GenerateRandomNumber(minHealth, maxHealth + 1);
    }

    protected int GenerateDamge()
    {
        int maxDamge = 40;
        int minDamge = 20;
        return Assistant.GenerateRandomNumber(minDamge, maxDamge + 1);
    }

    protected int GenerateArmor()
    {
        int maxArmor = 20;
        int minArmor = 10;
        return Assistant.GenerateRandomNumber(minArmor, maxArmor + 1);
    }
}

