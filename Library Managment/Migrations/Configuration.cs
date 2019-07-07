namespace Library_Managment.Migrations
{
    using Library_Managment.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library_Managment.DAL.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library_Managment.DAL.AppContext context)
        {

            //Books
            Book book1 = new Book
            {
                Name = "The Lion, the Witch and the Wardrobe",
                Author = "C. S. Lewis",
                Count = 8,
                CountNow = 6,
                Price = 55.5M
            };
            Book book2 = new Book
            {
                Name = "She: A History of Adventure",
                Author = "H. Rider Haggard",
                Count = 4,
                CountNow = 2,
                Price = 109.8M
            };
            Book book3 = new Book
            {
                Name = "The Adventures of Pinocchio",
                Author = "Carlo Collodi",
                Count = 2,
                CountNow = 1,
                Price = 87.5M
            };
            Book book4 = new Book
            {
                Name = "Vardi Wala Gunda",
                Author = "Ved Prakash Sharma",
                Count = 12,
                CountNow = 11,
                Price = 95.0M
            };
            Book book5 = new Book
            {
                Name = "The Da Vinci Code",
                Author = "Dan Brown",
                Count = 23,
                CountNow = 21,
                Price = 25.8M
            };
            Book book6 = new Book
            {
                Name = "Harry Potter and the Chamber of Secrets",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 47,
                Price = 89.9M
            };
            Book book7 = new Book
            {
                Name = "Harry Potter and the Prisoner of Azkaban",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 47,
                Price = 89.9M
            };
            Book book8 = new Book
            {
                Name = "The Alchemist",
                Author = "Paulo Coelho",
                Count = 9,
                CountNow = 7,
                Price = 94.7M
            };
            Book book9 = new Book
            {
                Name = "The Catcher in the Rye",
                Author = "	J. D. Salinger",
                Count = 38,
                CountNow = 37,
                Price = 23.8M
            };
            Book book10 = new Book
            {
                Name = "Think and Grow Rich",
                Author = "Napoleon Hill",
                Count = 81,
                CountNow = 79,
                Price = 25.2M
            };
            Book book11 = new Book
            {
                Name = "The Bridges of Madison County",
                Author = "Robert James Waller",
                Count = 21,
                CountNow = 20,
                Price = 17.4M
            };
            Book book12 = new Book
            {
                Name = "Ben-Hur: A Tale of the Christ",
                Author = "Lew Wallace",
                Count = 19,
                CountNow = 18,
                Price = 38M
            };
            Book book13 = new Book
            {
                Name = "Harry Potter and the Goblet of Fire",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 47,
                Price = 89.9M
            };
            Book book14 = new Book
            {
                Name = "Harry Potter and the Order of the Phoenix",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 46,
                Price = 89.9M
            };
            Book book15 = new Book
            {
                Name = "Harry Potter and the Half-Blood Prince",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 47,
                Price = 89.9M
            };
            Book book16 = new Book
            {
                Name = "Harry Potter and the Deathly Hallows",
                Author = "J. K. Rowling",
                Count = 48,
                CountNow = 47,
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


            //Customers
            Customer cust1 = new Customer
            {
                FullName = "Memmedli Agasef",
                CreateDate = DateTime.Today.AddDays(-5),
                PhoneNumber = "+994552995921",
                Address = "Baku,Nizami,Naxcivaski 72",
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

            //Administrators
            Administrator admin = new Administrator
            {
                Login = "Yolcu",
                Password = "Nasib",
                FullName = "Yolcu Nasib",
                CreateDate = DateTime.Today.AddDays(-309),
                PhoneNumber = "+9942995922",
                Address = "Baku,Nizami,Naxcivaski 72",
            };
            context.Administrators.AddOrUpdate(admin);
            context.SaveChanges();




            //orders

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


            Order order3 = new Order
            {
                CustomerId = cust5.Id,
                TakedDate = DateTime.Today.AddDays(-58)
            };

            Order order4 = new Order
            {
                CustomerId = cust1.Id,
                TakedDate = DateTime.Today.AddDays(-158)
            };
            Order order5 = new Order
            {
                CustomerId = cust2.Id,
                TakedDate = DateTime.Today.AddDays(-88)
            };

            Order order6 = new Order
            {
                CustomerId = cust8.Id,
                TakedDate = DateTime.Today.AddDays(-8)
            };
            Order order7 = new Order
            {
                CustomerId = cust6.Id,
                TakedDate = DateTime.Today.AddDays(-24)
            };

            Order order8 = new Order
            {
                CustomerId = cust7.Id,
                TakedDate = DateTime.Today.AddDays(-32)
            };
            context.Orders.AddOrUpdate(order1);
            context.Orders.AddOrUpdate(order2);
            context.Orders.AddOrUpdate(order3);
            context.Orders.AddOrUpdate(order4);
            context.Orders.AddOrUpdate(order5);
            context.Orders.AddOrUpdate(order6);
            context.Orders.AddOrUpdate(order7);
            context.Orders.AddOrUpdate(order8);
            context.SaveChanges();




            //rented book

            RentedBook rentedBook1 = new RentedBook
            {
                BookId = book1.Id,
                OrderId = order1.Id,
                ReturnDate = DateTime.Today.AddDays(10),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(10).Subtract(order1.TakedDate).TotalDays)*(book1.Price/28),
                Price = book1.Price
            };
            RentedBook rentedBook2 = new RentedBook
            {
                BookId = book6.Id,
                OrderId = order1.Id,
                ReturnDate = DateTime.Today.AddDays(17),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(17).Subtract(order1.TakedDate).TotalDays) * (book6.Price / 28),
                Price = book6.Price
            };
            RentedBook rentedBook3 = new RentedBook
            {
                BookId = book2.Id,
                OrderId = order1.Id,
                ReturnDate = DateTime.Today.AddDays(28),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(28).Subtract(order1.TakedDate).TotalDays) * (book2.Price / 28),
                Price = book2.Price

            };

            RentedBook rentedBook4 = new RentedBook
            {
                BookId = book1.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(4),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(4).Subtract(order2.TakedDate).TotalDays) * (book1.Price / 28),
                Price = book1.Price
            };
            RentedBook rentedBook5 = new RentedBook
            {
                BookId = book5.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(7),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(7).Subtract(order2.TakedDate).TotalDays) * (book5.Price / 28),
                Price = book5.Price
            };
            RentedBook rentedBook6 = new RentedBook
            {
                BookId = book9.Id,
                OrderId = order2.Id,
                ReturnDate = DateTime.Today.AddDays(8),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(8).Subtract(order2.TakedDate).TotalDays) * (book9.Price / 28),
                Price = book9.Price
            };

            RentedBook rentedBook7 = new RentedBook
            {
                BookId = book16.Id,
                OrderId = order3.Id,
                ReturnDate = DateTime.Today.AddDays(-10),
                isReturn = true,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(-10).Subtract(order3.TakedDate).TotalDays) * (book16.Price / 28),
                Price = book16.Price
            };
            RentedBook rentedBook8 = new RentedBook
            {
                BookId = book7.Id,
                OrderId = order3.Id,
                ReturnDate = DateTime.Today.AddDays(-1),
                isReturn = true,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(-1).Subtract(order3.TakedDate).TotalDays) * (book7.Price / 28),
                Price = book7.Price
            };
            RentedBook rentedBook9 = new RentedBook
            {
                BookId = book3.Id,
                OrderId = order3.Id,
                ReturnDate = DateTime.Today.AddDays(18),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(18).Subtract(order3.TakedDate).TotalDays) * (book3.Price / 28),
                Price = book3.Price
            };

            RentedBook rentedBook10 = new RentedBook
            {
                BookId = book4.Id,
                OrderId = order4.Id,
                ReturnDate = DateTime.Today.AddDays(1),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(1).Subtract(order4.TakedDate).TotalDays) * (book4.Price / 28),
                Price = book4.Price
            };
            RentedBook rentedBook11 = new RentedBook
            {
                BookId = book15.Id,
                OrderId = order4.Id,
                ReturnDate = DateTime.Today.AddDays(57),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(57).Subtract(order4.TakedDate).TotalDays) * (book15.Price / 28),
                Price = book15.Price
            };
            RentedBook rentedBook12 = new RentedBook
            {
                BookId = book11.Id,
                OrderId = order4.Id,
                ReturnDate = DateTime.Today.AddDays(28),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(28).Subtract(order4.TakedDate).TotalDays) * (book11.Price / 28),
                Price = book11.Price

            };

            RentedBook rentedBook13 = new RentedBook
            {
                BookId = book8.Id,
                OrderId = order4.Id,
                ReturnDate = DateTime.Today.AddDays(-1),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(-1).Subtract(order4.TakedDate).TotalDays) * (book8.Price / 28),
                Price = book8.Price
            };
            RentedBook rentedBook14 = new RentedBook
            {
                BookId = book8.Id,
                OrderId = order5.Id,
                ReturnDate = DateTime.Today.AddDays(17),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(17).Subtract(order5.TakedDate).TotalDays) * (book8.Price / 28),
                Price = book8.Price
            };
            RentedBook rentedBook15 = new RentedBook
            {
                BookId = book14.Id,
                OrderId = order5.Id,
                ReturnDate = DateTime.Today.AddDays(8),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(8).Subtract(order5.TakedDate).TotalDays) * (book14.Price / 28),
                Price = book14.Price
            };

            RentedBook rentedBook16 = new RentedBook
            {
                BookId = book13.Id,
                OrderId = order6.Id,
                ReturnDate = DateTime.Today.AddDays(2),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(2).Subtract(order6.TakedDate).TotalDays) * (book13.Price / 28),
                Price = book13.Price
            };
            RentedBook rentedBook17 = new RentedBook
            {
                BookId = book10.Id,
                OrderId = order7.Id,
                ReturnDate = DateTime.Today,
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.Subtract(order7.TakedDate).TotalDays) * (book10.Price / 28),
                Price = book10.Price
            };
            RentedBook rentedBook18 = new RentedBook
            {
                BookId = book10.Id,
                OrderId = order7.Id,
                ReturnDate = DateTime.Today.AddDays(18),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(18).Subtract(order7.TakedDate).TotalDays) * (book10.Price / 28),
                Price = book10.Price
            };


            RentedBook rentedBook19 = new RentedBook
            {
                BookId = book2.Id,
                OrderId = order8.Id,
                ReturnDate = DateTime.Today.AddDays(18),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(18).Subtract(order8.TakedDate).TotalDays) * (book2.Price / 28),
                Price = book2.Price
            };

            RentedBook rentedBook20 = new RentedBook
            {
                BookId = book12.Id,
                OrderId = order8.Id,
                ReturnDate = DateTime.Today.AddDays(-2),
                isReturn = true,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(-2).Subtract(order8.TakedDate).TotalDays) * (book12.Price / 28),
                Price = book12.Price
            };
            RentedBook rentedBook21 = new RentedBook
            {
                BookId = book14.Id,
                OrderId = order8.Id,
                ReturnDate = DateTime.Today.AddDays(-4),
                isReturn = true,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(-4).Subtract(order8.TakedDate).TotalDays) * (book14.Price / 28),
                Price = book14.Price
            };
            RentedBook rentedBook22 = new RentedBook
            {
                BookId = book5.Id,
                OrderId = order8.Id,
                ReturnDate = DateTime.Today.AddDays(18),
                isReturn = false,
                CalcPrice = Convert.ToDecimal(DateTime.Today.AddDays(18).Subtract(order8.TakedDate).TotalDays) * (book5.Price / 28),
                Price = book5.Price
            };
            context.RentedBooks.AddOrUpdate(rentedBook1);
            context.RentedBooks.AddOrUpdate(rentedBook2);
            context.RentedBooks.AddOrUpdate(rentedBook3);
            context.RentedBooks.AddOrUpdate(rentedBook4);
            context.RentedBooks.AddOrUpdate(rentedBook5);
            context.RentedBooks.AddOrUpdate(rentedBook6);
            context.RentedBooks.AddOrUpdate(rentedBook7);
            context.RentedBooks.AddOrUpdate(rentedBook8);
            context.RentedBooks.AddOrUpdate(rentedBook9);
            context.RentedBooks.AddOrUpdate(rentedBook10);
            context.RentedBooks.AddOrUpdate(rentedBook11);
            context.RentedBooks.AddOrUpdate(rentedBook12);
            context.RentedBooks.AddOrUpdate(rentedBook13);
            context.RentedBooks.AddOrUpdate(rentedBook14);
            context.RentedBooks.AddOrUpdate(rentedBook15);
            context.RentedBooks.AddOrUpdate(rentedBook16);
            context.RentedBooks.AddOrUpdate(rentedBook17);
            context.RentedBooks.AddOrUpdate(rentedBook18);
            context.RentedBooks.AddOrUpdate(rentedBook19);
            context.RentedBooks.AddOrUpdate(rentedBook20);
            context.RentedBooks.AddOrUpdate(rentedBook21);
            context.RentedBooks.AddOrUpdate(rentedBook22);
            context.SaveChanges();
        }
    }
}
