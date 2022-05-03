using Contracts;
using Data.Contracts;
using Data.DataAccess;
using EfcDataBase;
using EfcDataBase.SqliteDAO;

namespace Data.Test;

public class DataLoader
{
    static void Main(string[] args)
    {
        //IOrderService orderDao = new OrderDAO(fileContext: new FileContext())

        using (Context ctx = new())
        {
            ctx.Seed();
        }
    }
}