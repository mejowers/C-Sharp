using EntityFrameworkCoreDbFirst.Controllers;
using EntityFrameworkCoreDbFirst.Models;
using System;
using System.Linq;

namespace EntityFrameworkCoreDbFirst {
    class Program {
        static void Main(string[] args) {

            var custCtrl = new CustomersController();
            var orderCtrl = new OrdersController();
            var ordLinCtrl = new OrderLinesController();

            /*            //add a new customer
                        var newCust = new Customer() {
                            Id = 0, Name = "Meijer", State = "MN", Sales = 100000, Active = true
                        };
                        var rc = custCtrl.Add(newCust);

                        //get all customers
                        var customers = custCtrl.GetAll();
                        foreach (var cust in customers) {
                            Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.Sales} | {cust.Active} | {cust.State}");
                        }

                        //get customer by id
                        var cust = custCtrl.GetById(3);
                        Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.Sales} | {cust.Active} | {cust.State}");


                        //update a customer
                        var cust = custCtrl.GetById(6);
                        cust.Sales = 5000000;
                        var rc = custCtrl.Update(cust);
                        Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.Sales} | {cust.Active} | {cust.State}");


                        //delete a customer
                        var rmCust = custCtrl.Delete(6);
                        Console.WriteLine($"DELETED: {rmCust.Id} | {rmCust.Name} | {rmCust.Sales} | {rmCust.State}");

                        //add a new order
                        var newOrder = new Order() {
                            Id = 0, Date = new DateTime(2021, 07, 08), Description = "New Order", CustomerId = 2
                        };
                        var rc = orderCtrl.Add(newOrder);

                        //get all orders
                        var orders = orderCtrl.GetAll();
                        foreach (var ord in orders) {
                            Console.WriteLine($"{ord.Id} | {ord.Date} | {ord.Description} | {ord.CustomerId}");
                        }


                        //get order by id
                        var order = orderCtrl.GetById(6);
                        Console.WriteLine($"{order.Id} | {order.Date} | {order.Description} | {order.CustomerId}");


                        //update an order
                        var order = orderCtrl.GetById(6);
                        order.Description = "sample sample";
                        var rc = orderCtrl.Update(order);
                        Console.WriteLine($"{order.Id} | {order.Date} | {order.Description} | {order.CustomerId}");


                        //delete an order
                        var rmOrder = orderCtrl.Delete(3);
                        Console.WriteLine($"DELETED: {rmOrder.Id} | {rmOrder.Date} | {rmOrder.Description} | {rmOrder.CustomerId}");*/


            /* //add a new order line
             var newOrdLine = new OrderLine() {
                 Id = 0, Product = "Test", Description = "Test Test", Quantity = 1, Price = 100, OrderId = 1
             }; 
             var rc = ordLinCtrl.Add(newOrdLine);

             //get all orderLiness
             var ordLines = ordLinCtrl.GetAll();
                 foreach (var ordLin in ordLines) {
                     Console.WriteLine($"{ordLin.Id} | {ordLin.Product} | {ordLin.Description} |" +
                                       $" {ordLin.Quantity} | {ordLin.Price} | {ordLin.OrderId}");
                 }*/


            /*  //get order line by id
              var ordLine = ordLinCtrl.GetById(4);
              Console.WriteLine($"{ordLine.Id} | {ordLine.Product} | {ordLine.Description} | " +
                                $"{ordLine.Quantity} | {ordLine.Price} | {ordLine.OrderId}");


              //update an orderLIne
              var orderLine = ordLinCtrl.GetById(4);
              orderLine.Description = "sample sample";
              var line = ordLinCtrl.Update(orderLine);
              Console.WriteLine($"{orderLine.Id} | {orderLine.Product} | {ordLine.Description} | " +
                  $"{orderLine.Quantity} | {orderLine.Price} | {orderLine.OrderId}");*/


          /*  //delete an order
            var rmOrdLin = ordLinCtrl.Delete(4);
            Console.WriteLine($"DELETED: {rmOrdLin.Id} | {rmOrdLin.Product} | {rmOrdLin.Description} | " +
                $"{rmOrdLin.Quantity} | {rmOrdLin.Price} | {rmOrdLin.OrderId}");*/
        }
    }
}
