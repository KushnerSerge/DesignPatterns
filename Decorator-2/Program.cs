// See https://aka.ms/new-console-template for more information
using Decorator_2;

PlainPizza plainPizzaObj = new PlainPizza();
string plainPizza = plainPizzaObj.MakePizza();
Console.WriteLine(plainPizza);
PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
string chickenPizza = chickenPizzaDecorator.MakePizza();
Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
string vegPizza = vegPizzaDecorator.MakePizza();
Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");
Console.Read();
