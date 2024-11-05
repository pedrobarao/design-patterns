namespace Strategy.Strategies;

// 'Concrete Strategy' é a implementação da interface da estratégia.
public class WalkingRoute : IRouteStrategy
{
    public void DefineRoute()
    {
        Console.WriteLine("Definindo a rota a pé.");
    }
}