public class EasySoldierFabrick : SoldierBaseFactory
{
    public override SoldierBase Create()
    {
        //int minHealth = 100;
        //int maxHealth = 200;
        //int health = Assistant.GenerateRandomNumber(maxHealth,minHealth);
        return new EasySoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }
}

