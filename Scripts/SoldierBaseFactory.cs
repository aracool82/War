public abstract class SoldierBaseFactory
{
    public abstract SoldierBase Create();

    protected int GenerateHealth()
    {
        int maxHealth = 300;
        int minHealth = 200;
        return Assistant.GenerateRandomNumber(maxHealth + 1, minHealth);
    }

    protected int GenerateDamge()
    {
        int maxDamge = 40;
        int minDamge = 20;
        return Assistant.GenerateRandomNumber(maxDamge + 1, minDamge);
    }

    protected int GenerateArmor()
    {
        int maxArmor = 20;
        int minArmor = 10;
        return Assistant.GenerateRandomNumber(maxArmor + 1, minArmor);
    }
}

