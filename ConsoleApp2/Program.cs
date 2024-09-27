using System;

class Program
{
    // Функция для преобразования градусов в радианы
    public static double ToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }

    // Функция для расчета расстояния между двумя точками по их GPS-координатам
    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        const double R = 6371e3; // Радиус Земли в метрах
        double latNet = ToRadians(lat1); // Преобразуем широту первой точки в радианы
        double latNet2 = ToRadians(lat2); // Преобразуем широту второй точки в радианы
        double deltaLat = ToRadians(lat2 - lat1); // Разница широт в радианах
        double deltaLon = ToRadians(lon2 - lon1); // Разница долгот в радианах

        // Применение формулы хаверсинуса
        double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                   Math.Cos(latNet) * Math.Cos(latNet2) *
                   Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        double distance = R * c; // Расстояние между точками в метрах
        return distance;
    }

    // Функция для проверки, находится ли объект в пределах радиуса атаки
    public static bool CanAttack(double lat1, double lon1, double lat2, double lon2, double attackRadius)
    {
        double distance = CalculateDistance(lat1, lon1, lat2, lon2); // Вычисляем расстояние
        return distance <= attackRadius; // Сравниваем с радиусом атаки
    }

    static void Main(string[] args)
    {
        // Координаты первого объекта
        double lat1 = 59.93863;
        double lon1 = 30.31413;

        // координаты второго объекта
        double lat2 = 59.93563;
        double lon2 = 30.31513;

        // Задаем радиус атаки (1000 метров)
        double attackRadius = 1000;

        // Проверяем, может ли объект 1 атаковать объект 2
        if (CanAttack(lat1, lon1, lat2, lon2, attackRadius))
        {
            Console.WriteLine("Объект 1 может атаковать объект 2");
        }
        else
        {
            Console.WriteLine("Объект 2 находится вне зоны атаки");
        }
    }
}