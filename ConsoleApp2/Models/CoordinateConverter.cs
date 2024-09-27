using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackSimulation.Models
{
    public static class CoordinateConverter
    {
        public static double ToRadians(double degrees)
        {
            return degrees * (System.Math.PI / 180);
        }
    }
}
