﻿namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.MetanitCom
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
