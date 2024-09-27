namespace AttackSimulation.Services
{
    public interface IAttackStrategy
    {
        bool CanAttack(Models.GameObject attacker, Models.GameObject target, double attackRadius);
    }
}
