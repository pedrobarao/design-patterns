namespace Strategy.Strategies;

// 'Concrete Strategy' é a implementação da interface da estratégia.
public class CarRoute : IRouteStrategy
{
    public void DefineRoute()
    {
        Console.WriteLine("Definindo a rota para carro.");
    }
}