public class SoldierFabrick
{
    public SoldierBase CreateEasySolder()
    {
        return new EasySoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }

    public SoldierBase CreateSpecialSoldier()
    {
        return new SpecialSoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }

    public SoldierBase CreateMediumSoldier()
    {
        return new MediumSoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }

    public SoldierBase CreateHardSoldier()
    {
        return new HardSoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }

    private int GenerateHealth()
    {
        int maxHealth = 300;
        int minHealth = 200;
        return Assistant.GenerateRandomNumber(maxHealth + 1, minHealth);
    }

    private int GenerateDamge()
    {
        int maxDamge = 40;
        int minDamge = 20;
        return Assistant.GenerateRandomNumber(maxDamge + 1, minDamge);
    }

    private int GenerateArmor()
    {
        int maxArmor = 20;
        int minArmor = 10;
        return Assistant.GenerateRandomNumber(maxArmor + 1, minArmor);
    }
}

