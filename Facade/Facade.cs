using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade_
    {
        private readonly OnlineRestaurant _restaurant;
        private readonly ShippingService _shippingService;
        public Facade_(OnlineRestaurant restaurant, ShippingService shippingService)
        {
            _restaurant = restaurant;
            _shippingService = shippingService;
        }
        public void OrderFood(List<Order> orders)
        {
            foreach (var order in orders)
            {
                _restaurant.AddOrderToCart(order);
            }
            _restaurant.CompleteOrders();
            foreach (var order in orders)
            {
                _shippingService.AcceptOrder(order);
                _shippingService.CalculateShippingExpenses();
                _shippingService.ShipOrder();
            }
        }
    }
}
