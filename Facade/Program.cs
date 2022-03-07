// See https://aka.ms/new-console-template for more information

using Facade;

var restaurant = new OnlineRestaurant();
var shippingService = new ShippingService();
var facade = new Facade_(restaurant, shippingService);
var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };
facade.OrderFood(new List<Order>() { chickenOrder, sushiOrder });
Console.ReadLine();
