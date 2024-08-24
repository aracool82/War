public class HardSoldierFabrick : SoldierBaseFactory
{
    public override SoldierBase Create()
    {
        return new HardSoldier(GenerateHealth(),GenerateDamge(), GenerateArmor());
    }
}

