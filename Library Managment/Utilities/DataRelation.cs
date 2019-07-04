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
        private readonly DAL.AppContext _context = new DAL.AppContext();

        #region Fill Methods

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
            List<RentedBookList> rentedBooks = _context.RentedBooks.Where(r=>r.InfactDate!=null).Select(rb => new RentedBookList
            {
                Id = rb.Id,
                CustomerFullName = rb.Order.Customer.FullName,
                BookName = rb.Book.Name,
                TakingDate = rb.Order.TakedDate,
                ReturnDate = rb.ReturnDate,
                InfactDate = rb.InfactDate,
                Price = rb.Price
            }).ToList();

            return rentedBooks;
        }
        public class RentedBookList
        {
            public int Id { get; set; }

            public string CustomerFullName { get; set; }
            public string BookName { get; set; }
            public DateTime TakingDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public DateTime? InfactDate { get; set; }
            public decimal Price { get; set; }
        }


        public class SelectedBook
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime TakingDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public int BooksCount { get; set; }
            public decimal CalcPrice { get; set; }

        }
        public List<ReturnDashboardList> FillDashboardList(DateTime date)
        {
            if (date >= DateTime.Today)
            {
                List<ReturnDashboardList> returnLists = _context.RentedBooks.Include("Customer").Where(r => r.ReturnDate == date && r.InfactDate==null).GroupBy(r => r.OrderId).Select(rtb => new ReturnDashboardList
                {
                    Id = rtb.Key,
                    BooksCount = rtb.Count(),
                    CustomerFullName = rtb.FirstOrDefault().Order.Customer.FullName,
                    PhoneNumber = rtb.FirstOrDefault().Order.Customer.PhoneNumber
                }).ToList();
                return returnLists;
            }
            else
            {
                List<ReturnDashboardList> returnLists = _context.RentedBooks.Include("Customer").Where(r => r.ReturnDate <= date && r.InfactDate == null).GroupBy(r => r.OrderId).Select(rtb => new ReturnDashboardList
                {
                    Id = rtb.Key,
                    BooksCount = rtb.Count(),
                    CustomerFullName = rtb.FirstOrDefault().Order.Customer.FullName,
                    PhoneNumber = rtb.FirstOrDefault().Order.Customer.PhoneNumber
                }).ToList();
                return returnLists;
            }
        }
        public class ReturnDashboardList
        {
            public int Id { get; set; }

            public string CustomerFullName { get; set; }

            public string PhoneNumber { get; set; }

            public int BooksCount { get; set; }
        }
        #endregion

        #region Update Methods

        public void UpdateBooks(Book bk)
        {
            Book book = _context.Books.Find(bk.Id);

            book.Name = bk.Name;
            book.Author = bk.Author;
            book.Count = bk.Count;
            book.Price = bk.Price;

            _context.SaveChanges();
        }
        public void UpdateCustomer(Customer cs)
        {
            Customer customer = _context.Customers.Find(cs.Id);

            customer.FullName = cs.FullName;
            customer.CreateDate = cs.CreateDate;
            customer.PhoneNumber = cs.PhoneNumber;
            customer.Address = cs.Address;
            
            _context.SaveChanges();
        }

        public void UpdateAdministrator(Administrator ad)
        {
            Administrator administrator = _context.Administrators.Find(ad.Id);

            administrator.FullName = ad.FullName;
            administrator.Login = ad.Login;
            administrator.Password = ad.Password;
            administrator.CreateDate = ad.CreateDate;
            administrator.PhoneNumber = ad.PhoneNumber;
            administrator.Address = ad.Address;

            _context.SaveChanges();
        }



        #endregion

        #region Delete Methods

        public void DeleteBooks(int id)
        {
            Book book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = _context.Customers.Find(id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void DeleteAdministrator(int id)
        {
            Administrator administrator = _context.Administrators.Find(id);
            _context.Administrators.Remove(administrator);
            _context.SaveChanges();
        }

        #endregion

        #region Add Methods

        public void AddBooks(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void AddAdministrator(Administrator administrator)
        {
            _context.Administrators.Add(administrator);
            _context.SaveChanges();
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public void AddRentBook(RentedBook rentedBook)
        {
            _context.RentedBooks.Add(rentedBook);
            _context.SaveChanges();
        }

        #endregion

        #region Search
        public List<Book> SearchBooks(String name)
        {
            List<Book> books= _context.Books.Where(b => b.Name.Contains(name)).ToList();
            return books;
        }

        public List<Administrator> SearchAdministrators(String name)
        {
            List<Administrator> administrators = _context.Administrators.Where(a => a.FullName.Contains(name)).ToList();
            return administrators;
        }

        public List<Customer> SearchCustomers(String name)
        {
            List<Customer> customers = _context.Customers.Where(c => c.FullName.Contains(name)).ToList();
            return customers;
        }

        public List<RentedBook> SearchRentedBook(int id)
        {
            List<RentedBook> rentedBooks = _context.RentedBooks.Where(r => r.Order.CustomerId==id&&r.InfactDate==null).ToList();
            return rentedBooks;
        }

        #endregion

        public void RentBook(int id, int count)
        {
            Book book = _context.Books.Find(id);
            book.Count -= count;
            _context.SaveChanges();
        }
        public void ReturnBook(int id, int count)
        {
            Book book = _context.Books.Find(id);
            book.Count += count;
            _context.SaveChanges();
        }
    }



}
