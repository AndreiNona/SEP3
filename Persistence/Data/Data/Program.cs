// See https://aka.ms/new-console-template for more information

using System.Collections;
using Data.Contracts;
using Data.DataAccess;
using Data.Entities;
using EfcDataBase;

IOrderService orderDao = new OrderDAO(fileContext: new FileContext());
orderDao.AddAsync(new Order(1, 1, "Test order", false));

Console.WriteLine(await orderDao.GetAsync());

ICollection<Order> orders = await orderDao.GetAsync();

foreach (Order o in orders)
{
    Console.WriteLine(orders.Count);
    Console.WriteLine(o.item+ o.orderId);
}
