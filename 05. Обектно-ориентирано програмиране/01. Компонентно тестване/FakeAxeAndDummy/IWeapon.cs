public interface IWeapon
{
    void Attack(ITarget target);
    int AttackPoints { get; }
    int DurabilityPoints { get; }
}