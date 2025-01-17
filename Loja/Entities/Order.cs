using System;
using Loja.Entities.Enums;

namespace Loja.Entities {
    internal class Order {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) { }

        public void AddItem(OrderItem item) {}
        public void RemoveItem(OrderItem item) {}

        public double Total() {

            double sum;

            foreach (OrderItem item in Items) {

                

            }
        
        }

    }
}
