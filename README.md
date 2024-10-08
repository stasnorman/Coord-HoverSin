Чтобы атака происходила в радиусе 1000 метров между игроками, нужно выполнить несколько шагов, начиная с вычисления расстояния между двумя объектами на основе их GPS-координат и сравнивая его с радиусом атаки.

### Шаг 1. Преобразование GPS-координат в радианы

GPS-координаты, выраженные в градусах (широта и долгота), нужно сначала преобразовать в радианы, так как математические формулы для расчета расстояний на сфере (Земле) используют радианы.

Для преобразования:

$\text{радианы} = \text{градусы} \times \frac{\pi}{180}$

### Шаг 2. Формула хаверсинуса для расчета расстояния

Используется **формула хаверсинуса** для определения расстояния между двумя точками на сфере:
$a = \sin^2\left(\frac{\Delta\varphi}{2}\right) + \cos(\varphi_1) \cdot \cos(\varphi_2) \cdot \sin^2\left(\frac{\Delta\lambda}{2}\right)$

$c = 2 \cdot \text{atan2}\left(\sqrt{a}, \sqrt{1-a}\right)$

$d = R \cdot c$

Где:
- $(varphi_1)$, $(varphi_2)$ — широта первой и второй точки в радианах;
- $(\Delta\varphi)$ — разница широт в радианах;
- $(\Delta\lambda)$ — разница долгот в радианах;
- $(R)$ — радиус Земли (среднее значение \(6371\) км);
- $(d)$ — искомое расстояние между точками.

### Шаг 3. Сравнение с радиусом атаки

После того как будет вычислено расстояние $(d)$ между двумя объектами, мы можем сравнить это расстояние с заданным радиусом атаки. Если расстояние меньше или равно 1000 метров, значит один объект может атаковать другой. Иначе, объект находится вне зоны атаки.
