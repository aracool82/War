public class EasySoldierFabrick : SoldierBaseFactory
{
    public override SoldierBase Create()
    {
        return new EasySoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }
}

