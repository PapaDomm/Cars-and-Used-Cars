//welcome
using Cars_and_Used_Cars;

Console.WriteLine("Welcome to our Used Car Emporium!");

List<Car> cars = new List<Car>()
{
    new UsedCar("Chrysler", "Town and Country", 2012, 40000, 100000),
    new UsedCar("Cheverlot", "Cruze", 2016, 7420.60m, 80000),
    new UsedCar("Toyota", "Camry", 2001, 00.50m, 400000),
    new Car("Ford", "F150", 2024, 80000),
    new Car("Bugatti", "Chiron", 2024, 3900000),
    new Car("Subaru", "Forester", 2020, 30000),
    new Car("Toyota", "SuperBooster", 2037, 1000000)

};

bool runProgram = true;
while(runProgram)
{

    //Console.WriteLine("1- All Cars");
    //Console.WriteLine("2- Search by Make");
    //Console.WriteLine("3- Search by Year");
    //Console.WriteLine("4- Search by Price");
    //Console.WriteLine("5- Search by Used or New");



    Car.ListCars(cars);
    BuyCar(cars);

    //if(choice == 1)
    //{
    //    Car.ListCars(cars);
    //    BuyCar(cars);
    //}
    //else if(choice == 2)
    //{
    //    List<string> makes = new List<string>();
    //    foreach (Car car in cars.DistinctBy(c => c.make).ToList())
    //    {
    //        Console.WriteLine(car.make);
    //        makes.Add(car.make.ToLower());
    //    }

    //    Console.WriteLine("What Make of car are you searing for?");
    //    string _make = Validator.getValidChoice(makes);

    //    int index = 0;
    //    foreach(Car car in cars)
    //    {
    //        if(car.make.ToLower() == _make)
    //        {
    //            Console.WriteLine(index + "- " + car.ToString());
    //        }
    //        index++;
    //    }

    //    BuyCar(cars);
    //}
    //else if(choice == 3)
    //{
    //    List<string> models = new List<string>();
    //    foreach (Car car in cars.DistinctBy(c => c.model).ToList())
    //    {
    //        Console.WriteLine(car.model);
    //        models.Add(car.model.ToLower());
    //    }

    //    Console.WriteLine("What Make of car are you searing for?");
    //    string _model = Validator.getValidChoice(models);

    //    int index = 0;
    //    foreach (Car car in cars)
    //    {
    //        if (car.model.ToLower() == _model)
    //        {
    //            Console.WriteLine(index + "- " + car.ToString());
    //        }
    //        index++;
    //    }

    //    BuyCar(cars);
    //}
    //else if(choice == 4)
    //{

    //}
    //else
    //{

    //}

    runProgram = Validator.getContinue("Would you like to buy another car?:");
    Console.Clear();

    if (!runProgram)
    {
        Console.WriteLine("Goodbye!");
    }
}

static void BuyCar(List<Car> cars)
{
    Console.Write("\nWhich car would you like to buy?: ");
    int num = (Validator.getValidInt(1, cars.Count + 1) - 1);


    Console.WriteLine("\n" + cars[num].ToString() + "\n");

    Car.Remove(num, cars);
}