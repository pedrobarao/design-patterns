using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Products;

// 'Concrete Product'. Produz um produto concreto.
public class Truck : Transport
{
    public override void ExecuteOperation()
    {
        // Operação específica para o 'Produto' 'Truck'
        Console.WriteLine("Operação específica para Truck");
    }
}