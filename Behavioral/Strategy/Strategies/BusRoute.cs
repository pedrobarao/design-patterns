namespace Strategy.Strategies;

// 'Concrete Strategy' é a implementação da interface da estratégia.
public class BusRoute : IRouteStrategy
{
    public void DefineRoute()
    {
        Console.WriteLine("Definindo a rota de ônibus.");
    }
}