using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Managment.DAL;
using Library_Managment.Models;
using Library_Managment.Windows;


namespace Library_Managment.Utilities
{
    public class DataRelation
    {
        private DAL.AppContext _context = new DAL.AppContext();


        public List<Book> FillBooksList()
        {
            List<Book> books = _context.Books.ToList();

            return books;
        }
        public List<Administrator> FillAdministratorsList()
        {
            List<Administrator> administrators = _context.Administrators.ToList();

            return administrators;
        }

        public List<Customer> FillCustomersList()
        {
            List<Customer> customers = _context.Customers.ToList();

            return customers;
        }


        public List<RentedBookList> FillReportsList()
        {
            List<RentedBookList> rentedBooks = _context.RentedBooks.Select(rb=> new RentedBookList {
                Id =rb.Id,
                AdministratorFullName =rb.Administrator.FullName,
                CustomerFullName=rb.Customer.FullName,
                BookName=rb.Book.Name,
                TakingDate=rb.TakingDate,
                ReturnDate=rb.ReturnDate,
                InfactDate=rb.InfactDate,
                Price=rb.Price
            }).ToList();

            return rentedBooks;
        }


        public class RentedBookList
        {
            public int Id { get; set; }

            public string AdministratorFullName { get; set; }
            public string CustomerFullName { get; set; }
            public string BookName { get; set; }
            public DateTime TakingDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public DateTime? InfactDate { get; set; }
            public decimal Price { get; set; }
        }



        //public void FillReturnToday()
        //{
        //    //List<ReturnList> returnLists = _context.RentedBooks.Select(rb=> new ReturnList { Id = rb.Customer.Id, FullName = rb.Customer.FullName, PhoneNumber = rb.Customer.PhoneNumber, BookCount= _context.RentedBooks.(rb.CustomerId.) }).GroupBy(rb =>).ToList();



        //        //_context.RentedBooks.Select(rb => new { rb.CustomerId, rb.Customer.FullName, rb.Customer.PhoneNumber, rb.InfactDate.c });

        //    //_
        //    //_context.RentedBooks.SqlQuery("SELECT RB.CustomerId AS ID, C.FullName AS 'FULL NAME', C.PhoneNumber AS 'PHONE NUMBER', COUNT(RB.CustomerId)AS BOOKS FROM  RentedBooks RB JOIN Customers C ON RB.CustomerId = C.Id GROUP BY  C.FullName, C.PhoneNumber, RB.CustomerId").ToList();


        //}


    }


    class ReturnList
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public int BookCount { get; set; }
    }
}
