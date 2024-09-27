using System;

namespace AttackSimulation.Models
{
    public static class CoordinateConverter
    {
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
    }
}
