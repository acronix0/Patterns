using Patterns.AbstractFactories;
using Patterns.Transports;

class Program
{
    static void Init(TransportAbstractFactory factory)
    {
        //абстрактная фабрика
        List<Transport> transports = new List<Transport>
        {
            factory.CreateAbstractTruck(),
            factory.CreateAbstractCar(),
        };
    }
    static void Main()
    {
        List<Transport> transports = new List<Transport>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить легковой автомобиль");
            Console.WriteLine("2. Добавить грузовой автомобиль");
            Console.WriteLine("3. Отобразить информацию об автомобилях");
            Console.WriteLine("4. Изменить свойства автомобиля по индексу");
            Console.WriteLine("5. Вычислить расход топлива для заданного расстояния");


            Console.WriteLine("6. Выход");

            var car = new Car();
            var truck = new Truck();
            //фабричный метод
            //transports.Add(Transport.CreateTransport(TransportTypes.Truck));
            //transports.Add(Transport.CreateTransport(TransportTypes.Car));
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Car car = new Car();
                    Console.WriteLine("Введите название автомобиля:");
                    car.Name = Console.ReadLine();
                    Console.WriteLine("Введите вместимость бензобака:");
                    car.TankCapacity = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите расход топлива на 100 км:");
                    car.FuelConsumptionPer100Km = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите тип кузова:");
                    car.SetBodyType(Console.ReadLine());
                    transports.Add(car);
                    break;
                case 2:
                    //Truck truck = new Truck();
                    Console.WriteLine("Введите название грузовика:");
                    truck.Name = Console.ReadLine();
                    Console.WriteLine("Введите вместимость бензобака:");
                    truck.TankCapacity = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите расход топлива на 100 км:");
                    truck.FuelConsumptionPer100Km =
                   double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите грузоподъемность:");
                    truck.SetLoadCapacity(double.Parse(Console.ReadLine()));
                    transports.Add(truck);
                    break;
                case 3:
                    foreach (var transport in transports)
                    {
                        transport.ShowInfo();
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите индекс автомобиля для изменения:");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 0 && index < transports.Count)
                    {
                        Console.WriteLine("Текущая информация:");
                        transports[index].ShowInfo();
                        Console.WriteLine("Введите новое название автомобиля:");
                        transports[index].Name = Console.ReadLine();
                        Console.WriteLine("Введите новую вместимость бензобака:");
                        transports[index].TankCapacity =
                       double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новый расход топлива на 100 км: ");


                        transports[index].FuelConsumptionPer100Km =
                       double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Неправильный индекс!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите индекс автомобиля:");
                    int indexFuel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите расстояние:");
                    double distance = double.Parse(Console.ReadLine());
                    if (indexFuel >= 0 && indexFuel < transports.Count)
                    {
                        double consumption =
                       transports[indexFuel].CalculateFuelConsumption(distance);
                        Console.WriteLine($"Для преодоления расстояния в {distance}км потребуется { consumption} л топлива.");


                    }
                    else
                    {
                        Console.WriteLine("Неправильный индекс!");
                    }
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неправильный выбор!");
                    break;
            } 
        }
    }
}
