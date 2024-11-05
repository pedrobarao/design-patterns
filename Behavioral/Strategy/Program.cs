using Strategy.Contexts;
using Strategy.Strategies;

Console.WriteLine("## Strategy ##");

// Poderíamos também usar injeção de dependência para definir a estratégia padrão no construtor.
var context = new RouteContext();

Console.WriteLine("## Rota a pé");

context.SetStrategy(new WalkingRoute());
context.DefineRoute();

Console.WriteLine("## Rota de carro");

context.SetStrategy(new CarRoute());
context.DefineRoute();

Console.WriteLine("## Rota de ônibus");

context.SetStrategy(new BusRoute());
context.DefineRoute();

Console.ReadKey();