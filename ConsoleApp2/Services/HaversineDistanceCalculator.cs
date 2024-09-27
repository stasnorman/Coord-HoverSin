using AttackSimulation.Models;

namespace AttackSimulation.Services
{
    public class HaversineDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371e3; // Радиус Земли в метрах
            double φ1 = CoordinateConverter.ToRadians(lat1);
            double φ2 = CoordinateConverter.ToRadians(lat2);
            double Δφ = CoordinateConverter.ToRadians(lat2 - lat1);
            double Δλ = CoordinateConverter.ToRadians(lon2 - lon1);

            double a = System.Math.Sin(Δφ / 2) * System.Math.Sin(Δφ / 2) +
                       System.Math.Cos(φ1) * System.Math.Cos(φ2) *
                       System.Math.Sin(Δλ / 2) * System.Math.Sin(Δλ / 2);
            double c = 2 * System.Math.Atan2(System.Math.Sqrt(a), System.Math.Sqrt(1 - a));

            return R * c; // Расстояние в метрах
        }
    }
}
