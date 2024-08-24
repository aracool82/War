public class SpecialSoldierFabrick : SoldierBaseFactory
{
    public override SoldierBase Create()
    {
        return new SpecialSoldier(GenerateHealth(),GenerateDamge(),GenerateArmor());
    }
}
