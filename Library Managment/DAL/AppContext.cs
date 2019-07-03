using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library_Managment.Models;

namespace Library_Managment.DAL
{
    class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Administrator> Administrators  { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RentedBook> RentedBooks { get; set; }



}
}
