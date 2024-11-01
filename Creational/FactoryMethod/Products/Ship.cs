using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Products;

// 'Concrete Product'. Produz um produto concreto.
public class Ship : Transport
{
    public override void ExecuteOperation()
    {
        // Operação específica para o 'Produto' 'Ship'
        Console.WriteLine("Operação específica para Ship");
    }
}