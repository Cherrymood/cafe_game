private class Customers
{
    private int _tips;
    private bool _refuseWait;
    private Menue _menue;
    private string _key;
    private Kitchen _preparingTime;

    public Customer()
    {
        Console.WriteLine("Welcome to our customer! Here is our menue.");
        _menue = new Menue();
        _preparingTime = new Kitchen();
        _tips =  menue.menue(key) * 0,05;
        _refuseWait = false;
    } 
    
    private string MakeOrder(Menue menue)
    {
        Random rand = new Random();
        List<TValue> keys = Enumerable.ToList(_menue.menue.Keys);
        int size = _menue.menue.Count;
        _key = keys[rand.Next(size)];
        Console.WriteLine("Thank you, for your order. The waiting time is {0}, and the cost will be {1}", _preparingTime.menueTime(_key), _menue.menue(_key));
    
        return _key;
}

    private int Payment(string key)
    {
        Random r = new Random(); // could i initialize it only in constructor and use it in all methods?
        int wait = r.Next(0, 12);

        if (wait == _preparingTime.menueTime(_key))
        {
            Console.WriteLine("Thank you. Here you are my money for my order."

            return _menue.menue(_key) + _tips;
        }
        else
        {
            _refuseWait = true;

            Console.WriteLine("Thank you, I am in hurry. I can not wait anymore"

            return 0;
        }

    }




}