using AttackSimulation.Models;

namespace AttackSimulation.Services
{
    public class AttackStrategy : IAttackStrategy
    {
        private readonly IDistanceCalculator _distanceCalculator;

        public AttackStrategy(IDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
        }

        public bool CanAttack(GameObject attacker, GameObject target, double attackRadius)
        {
            double distance = _distanceCalculator.CalculateDistance(
                attacker.Latitude, attacker.Longitude,
                target.Latitude, target.Longitude
            );
            return distance <= attackRadius;
        }
    }
}
