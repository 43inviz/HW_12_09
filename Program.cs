using System.ComponentModel.DataAnnotations;

namespace HW_12_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();

            //    var clients = new List<Clients> {
            //        new Clients {Name = "Tom",Email = "tom123",Adress = "fst str." } ,
            //        new Clients {Name  = "Joe",Email = "Joe123",Adress = "sec.str"}

            //    };

            //    db.Clients.AddRange(clients);

            //    var products = new List<Products> {
            //        new Products{Name = "Apple",Price = 10.00m },
            //        new Products{Name = "Water",Price = 5.0m}
            //    };

            //    db.Products.AddRange(products);


            //    var orderDetails = new List<OrderDetails>
            //    {
            //        new OrderDetails{Product = products[0],ProductCount = 12 },
            //        new OrderDetails{Product = products[1],ProductCount = 5 }
            //    };

            //    var orders = new List<Orders> {
            //        new Orders{Client = clients[0],
            //        OrderDetail = new List<OrderDetails>{orderDetails[0] } },

            //        new Orders{ Client = clients[1],
            //            OrderDetail = new List<OrderDetails>{orderDetails[1] } }

            //    };

            //    db.Orders.AddRange(orders);

            //    db.SaveChanges();
            //}



            using (ApplicationContext db = new ApplicationContext())
            {
                var query = db.Clients.Select(c => new
                {
                    Name = c.Name,
                    Email = c.Email,
                    Adress = c.Adress,
                    TotalOrders = c.Orders.Count(),
                    TotalSpent = c.Orders.Select(o => o.OrderDetail.Sum(od => od.ProductCount * od.Product.Price)),
                    MostExpensiveProduct = c.Orders.SelectMany(o => o.OrderDetail).Select(od => od.Product.Price).Max()
                }).ToList();
            }
        }
    }
}
