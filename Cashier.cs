using System;

public class Cashier : IOrderBill
{
    public int OrderBill(Dish order)
    {
        Console.WriteLine("Cashier: your order bill is {0}", order.Price);
        
        return order.Price;
    }
}