using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApproch
    {
        public static void Main(string[] args)
        {
            // updateBook();
            // AddNewBook();
            //RemoveBook();
            //GetAllBook();

            //customer

            // AddnewCustomerandOrders();
            // AddOrder();

            // GetAllCustomersWithOrder_EagerLoading();

            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();

            Console.ReadLine();
        }
        //private static void updateBook()
        //{

        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 2;
        //    book.BookName = "#c";
        //    book.author = "lack";
        //    book.price = 500;


        //    try
        //    {
        //        ctx.Book.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" book updated successfuly");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //private static void AddNewBook()
        //{

        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 4;
        //    book.BookName = "linq";
        //    book.author = "mack";
        //    book.price = 800;


        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" book added successfuly");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void RemoveBook()
        //{

        //    var ctx = new BookContext();
        ////    Book book = new Book();
        ////    book.BookID = 3;
        ////    book.BookName = "linq";
        ////    book.author = "mack";
        ////    book.price = 800;

        //var Books = ctx.Books.Where(b => b.BookID == 4).SingleOrDefault;



        //    try
        //    {
        //        ctx.Book.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" book DELETED successfuly");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}



        //public IQueryable<Book> BookGetData()
        //{
        //    BookContext db = new BookContext();
        //    var Book = db.Book.Where(b => b.(e => e.Course));
        //    return query;
        //}


        //private static void GetAllBook()
        //{

        //    var ctx = new BookContext();

        //    var Book = ctx.Book;

        //    foreach (var book in Book)
        //    {
        //        Console.WriteLine(book.BookID + "  "+book.BookName+" "+book.author+ "  "+book.price+" " );
        //    }


        //}




        //customer

        //private static void AddnewCustomerandOrders()
        //{

        //    var ctx = new BookContext();
        //    Customer customer= new Customer();
        //    customer.ID = 1;
        //    customer.Name = "nithya";
        //    customer.Age = 35;

        //    Order ord = new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("  updated successfuly");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddOrder()
        //{

        //    var ctx = new BookContext();
        //    Order ord = new Order();
        //    ord.Order_ID = 200;
        //    ord.Amount = 4000;
        //    ord.OrderDate = DateTime.Now;

        //    var neword = ctx.Customers.Where(o => o.ID == 1).SingleOrDefault();
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("oredr added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}

        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");



        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());


                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext(); 

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();


            ctx.Dispose();


            UpdateCustomerName(customer);


        }

        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            // ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");


        }


    }
}
