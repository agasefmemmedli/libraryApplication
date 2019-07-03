namespace Library_Managment.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Library_Managment.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Library_Managment.DAL.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library_Managment.DAL.AppContext context)
        {
            Book book1 = new Book
            {
                Name = "The Lion, the Witch and the Wardrobe",
                Author= "C. S. Lewis",
                Count=8,
                Price = 55.5M
            };
            Book book2 = new Book
            {
                Name = "She: A History of Adventure",
                Author = "H. Rider Haggard",
                Count = 4,
                Price = 109.8M
            };
            Book book3 = new Book
            {
                Name = "The Adventures of Pinocchio",
                Author = "Carlo Collodi",
                Count = 2,
                Price = 87.5M
            };
            Book book4 = new Book
            {
                Name = "Vardi Wala Gunda",
                Author = "Ved Prakash Sharma",
                Count = 12,
                Price = 95.0M
            };
            Book book5 = new Book
            {
                Name = "The Da Vinci Code",
                Author = "Dan Brown",
                Count = 23,
                Price = 25.8M
            };
            Book book6 = new Book
            {
                Name = "Harry Potter and the Chamber of Secrets",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            Book book7 = new Book
            {
                Name = "Harry Potter and the Prisoner of Azkaban",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            Book book8 = new Book
            {
                Name = "The Alchemist",
                Author = "Paulo Coelho",
                Count = 9,
                Price = 94.7M
            };
            Book book9 = new Book
            {
                Name = "The Catcher in the Rye",
                Author = "	J. D. Salinger",
                Count = 38,
                Price = 23.8M
            };
            Book book10 = new Book
            {
                Name = "Think and Grow Rich",
                Author = "Napoleon Hill",
                Count = 81,
                Price = 25.2M
            };
            Book book11 = new Book
            {
                Name = "The Bridges of Madison County",
                Author = "Robert James Waller",
                Count = 21,
                Price = 17.4M
            };
            Book book12 = new Book
            {
                Name = "Ben-Hur: A Tale of the Christ",
                Author = "Lew Wallace",
                Count = 19,
                Price = 38M
            };
            Book book13 = new Book
            {
                Name = "Harry Potter and the Goblet of Fire",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            Book book14 = new Book
            {
                Name = "Harry Potter and the Order of the Phoenix",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            Book book15 = new Book
            {
                Name = "Harry Potter and the Half-Blood Prince",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            Book book16 = new Book
            {
                Name = "Harry Potter and the Deathly Hallows",
                Author = "J. K. Rowling",
                Count = 48,
                Price = 89.9M
            };
            
                context.Books.AddOrUpdate(book1);
                context.Books.AddOrUpdate(book2);
                context.Books.AddOrUpdate(book3);
                context.Books.AddOrUpdate(book4);
                context.Books.AddOrUpdate(book5);
                context.Books.AddOrUpdate(book6);
                context.Books.AddOrUpdate(book7);
                context.Books.AddOrUpdate(book8);
                context.Books.AddOrUpdate(book9);
                context.Books.AddOrUpdate(book10);
                context.Books.AddOrUpdate(book11);
                context.Books.AddOrUpdate(book12);
                context.Books.AddOrUpdate(book13);
                context.Books.AddOrUpdate(book14);
                context.Books.AddOrUpdate(book15);
                context.Books.AddOrUpdate(book16);
                context.SaveChanges();
            


            Customer cust1 = new Customer
            {
                FullName= "Memmedli Agasef",
                CreateDate= DateTime.Today.AddDays(-5),
                PhoneNumber="+994552995921",
                Address="Baku,Nizami,Naxcivaski 72",
            };

            Customer cust2 = new Customer
            {
                FullName = "Ehmedov Behruz",
                CreateDate = DateTime.Today.AddDays(-28),
                PhoneNumber = "+994556965575",
                Address = "Tovuz,Qovlar kendi",
            };
            Customer cust3 = new Customer
            {
                FullName = "Memmedov Teymur",
                CreateDate = DateTime.Today.AddDays(-95),
                PhoneNumber = "+994772456372",
                Address = "Masalli,Hacitepe k",
            };
        
            Customer cust4 = new Customer
            {
                FullName = "Veliyev Xudaverdi",
                CreateDate = DateTime.Today.AddDays(-16),
                PhoneNumber = "+994502993756",
                Address = "Sumqayit,7 microray",
            };
    
            Customer cust5 = new Customer
            {
                FullName = "Isgenderov Aynur",
                CreateDate = DateTime.Today.AddDays(-51),
                PhoneNumber = "+994709938282",
                Address = "Gence,Nizami",
            };

            Customer cust6 = new Customer
            {
                FullName = "Hesenov Ates",
                CreateDate = DateTime.Today.AddDays(-45),
                PhoneNumber = "+9948922121",
                Address = "Baki,Binegedi,Eliaga Shix 21",
            };
        
            Customer cust7 = new Customer
            {
                FullName = "Baxisov Xamid",
                CreateDate = DateTime.Today.AddDays(-15),
                PhoneNumber = "+994552913425",
                Address = "Baki,Sabuncu, Oskar Efendiyev 1a",
            };
        
            Customer cust8 = new Customer
            {
                FullName = "Isgenderov Serxan",
                CreateDate = DateTime.Today.AddDays(-102),
                PhoneNumber = "+9945565353",
                Address = "Baki,Ehmedli,Nesreddin Tusi 38",
            };


            context.Customers.AddOrUpdate(cust1);
            context.Customers.AddOrUpdate(cust2);
            context.Customers.AddOrUpdate(cust3);
            context.Customers.AddOrUpdate(cust4);
            context.Customers.AddOrUpdate(cust5);
            context.Customers.AddOrUpdate(cust6);
            context.Customers.AddOrUpdate(cust7);
            context.Customers.AddOrUpdate(cust8);

            context.SaveChanges();


            Administrator admin = new Administrator
            {
                Login = "Admin",
                Password = "admin",
                FullName = "Memmedli Aga",
                CreateDate = DateTime.Today.AddDays(-309),
                PhoneNumber="+9942995922",
                Address= "Baku,Nizami,Naxcivaski 72",
            };
            context.Administrators.AddOrUpdate(admin);
            context.SaveChanges();

            
            Order order1 = new Order
            {
                CustomerId = cust3.Id,
                TakedDate = DateTime.Today
            };

            Order order2 = new Order
            {
                CustomerId = cust4.Id,
                TakedDate = DateTime.Today
            };
            context.Orders.AddOrUpdate(order1);
            context.Orders.AddOrUpdate(order2);
            context.SaveChanges();


            RentedBook  rentedBook1 = new RentedBook
             {
                 BookId = book1.Id,
                 OrderId = order1.Id,
                 ReturnDate = DateTime.Today.AddDays(10),
                 Price = (book1.Price / 28) * 10
             };
            RentedBook rentedBook2 = new RentedBook
            {
                BookId = book5.Id,
                OrderId = order1.Id,
                ReturnDate = DateTime.Today.AddDays(17),
                Price = (book1.Price / 28) * 17
            };
            RentedBook rentedBook3 = new RentedBook
            {
                BookId = book6.Id,
                OrderId = order1.Id,
                ReturnDate = DateTime.Today.AddDays(28),
                Price = (book1.Price / 28) * 28
            };

            RentedBook rentedBook4 = new RentedBook
            {
                BookId = book1.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(4),
                Price = (book1.Price / 28) * 4
            };
            RentedBook rentedBook5 = new RentedBook
            {
                BookId = book5.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(7),
                Price = (book1.Price / 28) * 7
            };
            RentedBook rentedBook6 = new RentedBook
            {
                BookId = book9.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(8),
                Price = (book1.Price / 28) * 8
            };
            
            context.RentedBooks.AddOrUpdate(rentedBook1);
            context.RentedBooks.AddOrUpdate(rentedBook2);
            context.RentedBooks.AddOrUpdate(rentedBook3);
            context.RentedBooks.AddOrUpdate(rentedBook4);
            context.RentedBooks.AddOrUpdate(rentedBook5);
            context.RentedBooks.AddOrUpdate(rentedBook6);
            context.SaveChanges();
        }
    }
}
