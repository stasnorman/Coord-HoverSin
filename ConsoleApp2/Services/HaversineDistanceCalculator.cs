using AttackSimulation.Models;

namespace AttackSimulation.Services
{
    public class HaversineDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371e3; // Радиус Земли в метрах
            double latOne = CoordinateConverter.ToRadians(lat1);
            double latTwo = CoordinateConverter.ToRadians(lat2);
            double deltaLat = CoordinateConverter.ToRadians(lat2 - lat1);
            double deltaLon = CoordinateConverter.ToRadians(lon2 - lon1);

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(latOne) * Math.Cos(latTwo) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // Расстояние в метрах
        }
    }
}
