using System;

namespace CarProject
{
    class Avto
    {
        public string Number { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; } 
        public int Mileage { get; set; } 
        public double Speed { get; set; } 
        public double MaxSpeed { get; set; } 
        public double TankCapacity { get; set; } 
        public double Acceleration { get; set; } 
        public double Braking { get; set; } 
        public (int X, int Y) Position { get; set; } 
        public (int X, int Y) Destination { get; set; } 

        public void Initialize(string number, double tankCapacity, double fuelConsumption,
                              double maxSpeed, double acceleration, double braking,
                              int startX = 0, int startY = 0)
        {
            Number = number;
            TankCapacity = tankCapacity;
            Fuel = tankCapacity; 
            FuelConsumption = fuelConsumption;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Braking = braking;
            Mileage = 0;
            Speed = 0;
            Position = (startX, startY);
            Destination = (startX, startY);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Машина: {Number}");
            Console.WriteLine($"Бензина: {Fuel:F1} / {TankCapacity:F1} литров");
            Console.WriteLine($"Расход: {FuelConsumption:F1} л/100км");
            Console.WriteLine($"Пробег: {Mileage} км");
            Console.WriteLine($"Скорость: {Speed:F1} км/ч (макс: {MaxSpeed} км/ч)");
            Console.WriteLine($"Ускорение: {Acceleration:F1} м/с², Торможение: {Braking:F1} м/с²");
            Console.WriteLine($"Позиция: X={Position.X}, Y={Position.Y}");
            Console.WriteLine($"Назначение: X={Destination.X}, Y={Destination.Y}");
        }

        public void SetDestination(int x, int y)
        {
            Destination = (x, y);
            Console.WriteLine($"Установлена новая точка назначения: X={x}, Y={y}");
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Нельзя заправить отрицательное количество топлива");
                return;
            }

            double newFuel = Fuel + liters;
            if (newFuel > TankCapacity)
            {
                Console.WriteLine($"Заправлено {TankCapacity - Fuel:F1} литров (бак полный)");
                Fuel = TankCapacity;
            }
            else
            {
                Fuel = newFuel;
                Console.WriteLine($"Заправлено {liters:F1} литров. Теперь бензина: {Fuel:F1}");
            }
        }

        public void DriveToDestination()
        {
            if (this.Speed == 0)
            {
                Console.WriteLine("Скорость равна 0!");
                return;
            }
            if (Position.X == Destination.X && Position.Y == Destination.Y)
            {
                Console.WriteLine("Уже находимся в точке назначения");
                return;
            }

            
            double distance = Math.Sqrt(Math.Pow(Destination.X - Position.X, 2) +
                                      Math.Pow(Destination.Y - Position.Y, 2));

            Console.WriteLine($"Расстояние до точки: {distance:F1} км");

            
            double consumptionFactor = 1.0;
            if (Speed > 90) consumptionFactor = 1.2; 
            else if (Speed < 40) consumptionFactor = 1.1; 

            double fuelNeeded = (FuelConsumption * distance / 100) * consumptionFactor;

            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                Mileage += (int)distance;
                Position = Destination;
                Console.WriteLine($"Приехали в точку X={Destination.X}, Y={Destination.Y}");
                Console.WriteLine($"Потрачено топлива: {fuelNeeded:F1} л. Осталось: {Fuel:F1} л");
            }
            else
            {
                double maxDistance = Fuel * 100 / (FuelConsumption * consumptionFactor);
                Console.WriteLine($"Недостаточно бензина. Можете проехать максимум {maxDistance:F1} км");


                double ratio = maxDistance / distance;
                int reachableX = Position.X + (int)((Destination.X - Position.X) * ratio);
                int reachableY = Position.Y + (int)((Destination.Y - Position.Y) * ratio);

                Console.WriteLine($"Можете доехать до X={reachableX}, Y={reachableY}");

                Console.Write("Заправиться? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("Сколько литров?: ");
                    if (double.TryParse(Console.ReadLine(), out double liters))
                    {
                        Refuel(liters);
                        DriveToDestination(); 
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                }
            }
        }

        public void Drive(int dx, int dy)
        {
            if (this.Speed == 0)
            {
                Console.WriteLine("Скорость равна 0!");
                return;
            }
            if (dx == 0 && dy == 0)
            {
                Console.WriteLine("Не указано направление движения");
                return;
            }

            
            double distance = Math.Sqrt(dx * dx + dy * dy);

            double consumptionFactor = 1.0;
            if (Speed > 90) consumptionFactor = 1.2;
            else if (Speed < 40) consumptionFactor = 1.1;

            double fuelNeeded = (FuelConsumption * distance / 100) * consumptionFactor;

            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                Mileage += (int)distance;
                Position = (Position.X + dx, Position.Y + dy);
                Console.WriteLine($"Проехали: X={dx}, Y={dy}. Новые координаты: X={Position.X}, Y={Position.Y}");
                Console.WriteLine($"Потрачено топлива: {fuelNeeded:F1} л. Осталось: {Fuel:F1} л");
            }
            else
            {
                double maxDistance = Fuel * 100 / (FuelConsumption * consumptionFactor);
                Console.WriteLine($"Недостаточно бензина. Можете проехать максимум {maxDistance:F1} км");

                
                double ratio = maxDistance / distance;
                int actualDx = (int)(dx * ratio);
                int actualDy = (int)(dy * ratio);

                Console.WriteLine($"Можете проехать: X={actualDx}, Y={actualDy}");

                Console.Write("Заправиться? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("Сколько литров?: ");
                    if (double.TryParse(Console.ReadLine(), out double liters))
                    {
                        Refuel(liters);
                        Drive(dx, dy); 
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                }
            }
        }

        public void Accelerate()
        {
            if (Speed >= MaxSpeed)
            {
                Console.WriteLine("Достигнута максимальная скорость");
                return;
            }

            Speed += Acceleration * 3.6;
            if (Speed > MaxSpeed) Speed = MaxSpeed;
            Console.WriteLine($"Ускоряемся. Текущая скорость: {Speed:F1} км/ч");
        }

        public void Brake()
        {
            if (Speed <= 0)
            {
                Console.WriteLine("Машина уже стоит");
                return;
            }

            Speed -= Braking * 3.6;
            if (Speed < 0) Speed = 0;
            Console.WriteLine($"Тормозим. Текущая скорость: {Speed:F1} км/ч");
        }
    }

    class AvtoPark
    {
        Avto[] cars;
        Random rnd = new Random();

        public AvtoPark(int count)
        {
            cars = new Avto[count];
            for (int i = 0; i < count; i++)
            {
                cars[i] = new Avto();
                string number = "A" + rnd.Next(100, 999);
                double tankCapacity = 30 + rnd.NextDouble() * 30; 
                double consumption = 5 + rnd.NextDouble() * 10; 
                double maxSpeed = 120 + rnd.NextDouble() * 80; 
                double acceleration = 1 + rnd.NextDouble() * 2; 
                double braking = 3 + rnd.NextDouble() * 3; 
                int startX = rnd.Next(-100, 100);
                int startY = rnd.Next(-100, 100);

                cars[i].Initialize(number, Math.Round(tankCapacity, 1), Math.Round(consumption, 1), Math.Round(maxSpeed, 0), Math.Round(acceleration, 1), Math.Round(braking, 1), startX, startY);
            }
        }

        public void ShowAllCars()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Машина #{i + 1}");
                cars[i].ShowInfo();
            }
        }

        public Avto GetCar(int index)
        {
            if (index >= 0 && index < cars.Length)
                return cars[index];
            return null;
        }

        public int CarCount => cars.Length;

        public void Crash()
        {
            if (cars.Length < 2)
            {
                Console.WriteLine("Недостаточно машин для аварии");
                return;
            }

            int car1 = rnd.Next(cars.Length);
            int car2;
            do { car2 = rnd.Next(cars.Length); } while (car2 == car1);

            double distance = Math.Sqrt(
                Math.Pow(cars[car1].Position.X - cars[car2].Position.X, 2) +
                Math.Pow(cars[car1].Position.Y - cars[car2].Position.Y, 2));

            if (distance < 10)
            {
                Console.WriteLine($"Столкнулись {cars[car1].Number} (X={cars[car1].Position.X}, Y={cars[car1].Position.Y}) " +
                                $"и {cars[car2].Number} (X={cars[car2].Position.X}, Y={cars[car2].Position.Y})");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Машины слишком далеко друг от друга ({distance:F1} км) для аварии");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько машин создать?: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некорректный ввод. Создано 5 машин по умолчанию");
                n = 5;
            }

            AvtoPark park = new AvtoPark(n);

            while (true)
            {
                Console.WriteLine("Главное меню:");
                Console.WriteLine("1. Показать все машины");
                Console.WriteLine("2. Выбрать машину");
                Console.WriteLine("3. Авария");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        park.ShowAllCars();
                        break;
                    case "2":
                        Console.Write($"Номер машины (1-{park.CarCount}): ");
                        if (int.TryParse(Console.ReadLine(), out int carNum) && carNum >= 1 && carNum <= park.CarCount)
                            CarMenu(park.GetCar(carNum - 1));
                        else
                            Console.WriteLine("Неверный номер машины");
                        break;
                    case "3":
                        park.Crash();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }

        static void CarMenu(Avto car)
        {
            while (true)
            {
                Console.WriteLine($"Меню машины {car.Number}");
                Console.WriteLine("1. Информация");
                Console.WriteLine("2. Движение по координатам");
                Console.WriteLine("3. Движение к точке назначения");
                Console.WriteLine("4. Установить точку назначения");
                Console.WriteLine("5. Заправка");
                Console.WriteLine("6. Ускориться");
                Console.WriteLine("7. Тормозить");
                Console.WriteLine("8. Назад");
                Console.Write("Выберите: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        car.ShowInfo();
                        break;
                    case "2":
                        Console.Write("Смещение по X: ");
                        if (!int.TryParse(Console.ReadLine(), out int dx))
                        {
                            Console.WriteLine("Некорректный ввод X");
                            break;
                        }
                        Console.Write("Смещение по Y: ");
                        if (!int.TryParse(Console.ReadLine(), out int dy))
                        {
                            Console.WriteLine("Некорректный ввод Y");
                            break;
                        }
                        car.Drive(dx, dy);
                        break;
                    case "3":
                        car.DriveToDestination();
                        break;
                    case "4":
                        Console.Write("Координата X назначения: ");
                        if (!int.TryParse(Console.ReadLine(), out int destX))
                        {
                            Console.WriteLine("Некорректный ввод X");
                            break;
                        }
                        Console.Write("Координата Y назначения: ");
                        if (!int.TryParse(Console.ReadLine(), out int destY))
                        {
                            Console.WriteLine("Некорректный ввод Y");
                            break;
                        }
                        car.SetDestination(destX, destY);
                        break;
                    case "5":
                        Console.Write("Сколько литров?: ");
                        if (double.TryParse(Console.ReadLine(), out double liters))
                            car.Refuel(liters);
                        else
                            Console.WriteLine("Некорректный ввод");
                        break;
                    case "6":
                        car.Accelerate();
                        break;
                    case "7":
                        car.Brake();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}