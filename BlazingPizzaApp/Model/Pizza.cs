namespace BlazingPizzaApp.Model;

using BlazingPizzaApp;
public class Pizza
{
    public int Id { get; set; }
    public int SpecialId { get; set; }
    public PizzaSpecial Special { get; set; } = new();
    public int Size { get; set; } = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public decimal GetTotalPrice()
    {
        return Special != null ? Special.BasePrice * ((decimal)Size / 12) : 0;
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}