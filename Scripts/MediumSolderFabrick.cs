public class MediumSoldierFabrick : SoldierBaseFactory
{
    public override SoldierBase Create()
    {
        return new MediumSoldier(GenerateHealth(), GenerateDamge(), GenerateArmor());
    }
}