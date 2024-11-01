using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Creators.Abstract;

// 'Creator'. É a classe que define o contrato para retornar um 'Produto'.

public abstract class LogisticFactory
{
    // Factory Method
    public abstract Transport CreateTransport();

    // Aqui poderíamos usar o IServiceProvider para resolver as dependências.
    public static LogisticFactory GetLogisticFactory(LogisticType type)
    {
        return type switch
        {
            LogisticType.Road => new RoadLogisticFactory(),
            LogisticType.Sea => new SeaLogisticFactory(),
            _ => throw new ApplicationException("Operação não conhecida.")
        };
    }
}