using BlazingPizzaApp.Model;

namespace BlazingPizzaApp.Services;

public class OrderState
{
    public Order Order { get; private set; } = new Order();

    // Method baru untuk menghapus pizza dari keranjang
    public void RemoveConfiguredPizza(Pizza pizza)
    {
        Order.Pizzas.Remove(pizza);
    }
}