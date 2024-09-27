using System;

namespace AttackSimulation.Models
{
    public class GameObject
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GameObject(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
