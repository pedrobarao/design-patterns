﻿using FactoryMethod.Creators.Abstract;
using FactoryMethod.Products;
using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Creators;

// 'Concrete Creator''. Implementa 'Creator' e retorna um 'Produto' concreto.
public class SeaLogisticFactory : LogisticFactory
{
    // Factory Method
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}