using Strategy.Strategies;

namespace Strategy.Contexts;

// O 'Context' faz referência a uma das estratégias.
// O 'Context' não conhece a implementação da estratégia, ele apenas faz uso da interface da delas.
public class RouteContext
{
    private IRouteStrategy? _strategy;

    // Se necessário, a estratégia pode ser alterada em tempo de execução.
    public void SetStrategy(IRouteStrategy strategy)
    {
        _strategy = strategy;
    }

    // O 'Context' delega parte do trabalho para a implementação da estratégia.
    public void DefineRoute()
    {
        _strategy.DefineRoute();
    }
}