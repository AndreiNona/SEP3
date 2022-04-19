using Data.Contracts;
using Data.DataAccess;

namespace Data.Test;

public class DataLoader
{
    static void Main(string[] args)
    {
        IOrderService orderDao = new OrderDAO(fileContext: new FileContext());
    }
}