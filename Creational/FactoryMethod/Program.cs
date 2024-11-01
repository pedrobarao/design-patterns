using FactoryMethod.Creators;
using FactoryMethod.Creators.Abstract;

Console.WriteLine("## Factory Method ##");

Console.WriteLine("## Truck");

var truck = LogisticFactory.GetLogisticFactory(LogisticType.Road)
    .CreateTransport();

truck.ExecuteOperation();

Console.WriteLine("## Ship");

var ship = LogisticFactory.GetLogisticFactory(LogisticType.Sea)
    .CreateTransport();

ship.ExecuteOperation();

Console.ReadKey();