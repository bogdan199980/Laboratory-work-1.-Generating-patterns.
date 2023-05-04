using System;

// Абстрактний клас Creator, який містить абстрактний метод FactoryMethod()
abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

// Інтерфейс IProduct, який буде реалізований класами-спадкоємцями
interface IProduct
{
    void Operation();
}

// Конкретний клас ConcreteProductA, який реалізує інтерфейс IProduct
class ConcreteProductA : IProduct
{
    public void Operation()
    {
        Console.WriteLine("ConcreteProductA.Operation");
    }
}

// Конкретний клас ConcreteProductB, який реалізує інтерфейс IProduct
class ConcreteProductB : IProduct
{
    public void Operation()
    {
        Console.WriteLine("ConcreteProductB.Operation");
    }
}

// Клас ConcreteCreatorA, який успадковується від абстрактного класу Creator
class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

class ConcreteCreatorB : Creator
{
    // Конкретний об'єкт, який повертає метод FactoryMethod(), в залежності від потреб клієнта
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

class Client
{
    static void Main(string[] args)
    {
        // Створення конкретного об'єкту ConcreteCreatorA
        Creator creatorA = new ConcreteCreatorA();
        IProduct productA = creatorA.FactoryMethod();
        productA.Operation(); // ConcreteProductA.Operation

        // Створення конкретного об'єкту ConcreteCreatorB
        Creator creatorB = new ConcreteCreatorB();
        IProduct productB = creatorB.FactoryMethod();
        productB.Operation(); // ConcreteProductB.Operation
    }
}