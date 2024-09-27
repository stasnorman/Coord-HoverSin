using AttackSimulation.Models;
using AttackSimulation.Services;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты
        GameObject attacker = new GameObject(59.13863, 30.31413);
        GameObject target = new GameObject(59.93563, 30.31513);

        // Указываем радиус атаки (1000 метров)
        double attackRadius = 1000;

        // Используем HaversineDistanceCalculator для расчета расстояния
        IDistanceCalculator distanceCalculator = new HaversineDistanceCalculator();

        // Применяем стратегию атаки
        IAttackStrategy attackStrategy = new AttackStrategy(distanceCalculator);

        // Проверяем, может ли атакующий объект атаковать цель
        if (attackStrategy.CanAttack(attacker, target, attackRadius))
        {
            Console.WriteLine("Объект может атаковать цель.");
        }
        else
        {
            Console.WriteLine("Цель вне радиуса атаки.");
        }
    }
}
