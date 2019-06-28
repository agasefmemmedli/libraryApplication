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
                Position="1/2",
                Price = 55.5M
            };
            Book book2 = new Book
            {
                Name = "She: A History of Adventure",
                Author = "H. Rider Haggard",
                Count = 4,
                Position = "1/4",
                Price = 109.8M
            };
            Book book3 = new Book
            {
                Name = "The Adventures of Pinocchio",
                Author = "Carlo Collodi",
                Count = 2,
                Position = "2/1",
                Price = 87.5M
            };
            Book book4 = new Book
            {
                Name = "Vardi Wala Gunda",
                Author = "Ved Prakash Sharma",
                Count = 12,
                Position = "2/3",
                Price = 95.0M
            };
            Book book5 = new Book
            {
                Name = "The Da Vinci Code",
                Author = "Dan Brown",
                Count = 23,
                Position = "3/2",
                Price = 25.8M
            };
            Book book6 = new Book
            {
                Name = "Harry Potter and the Chamber of Secrets",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            Book book7 = new Book
            {
                Name = "Harry Potter and the Prisoner of Azkaban",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            Book book8 = new Book
            {
                Name = "The Alchemist",
                Author = "Paulo Coelho",
                Count = 9,
                Position = "1/2",
                Price = 94.7M
            };
            Book book9 = new Book
            {
                Name = "The Catcher in the Rye",
                Author = "	J. D. Salinger",
                Count = 38,
                Position = "3/1",
                Price = 23.8M
            };
            Book book10 = new Book
            {
                Name = "Think and Grow Rich",
                Author = "Napoleon Hill",
                Count = 81,
                Position = "3/4",
                Price = 25.2M
            };
            Book book11 = new Book
            {
                Name = "The Bridges of Madison County",
                Author = "Robert James Waller",
                Count = 21,
                Position = "2/4",
                Price = 17.4M
            };
            Book book12 = new Book
            {
                Name = "Ben-Hur: A Tale of the Christ",
                Author = "Lew Wallace",
                Count = 19,
                Position = "1/4",
                Price = 38M
            };
            Book book13 = new Book
            {
                Name = "Harry Potter and the Goblet of Fire",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            Book book14 = new Book
            {
                Name = "Harry Potter and the Order of the Phoenix",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            Book book15 = new Book
            {
                Name = "Harry Potter and the Half-Blood Prince",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            Book book16 = new Book
            {
                Name = "Harry Potter and the Deathly Hallows",
                Author = "J. K. Rowling",
                Count = 48,
                Position = "2/2",
                Price = 89.9M
            };
            if (context.Books.Any(b=>b.Name==book1.Name))
            {
                context.Books.Add(book1);
                context.Books.Add(book2);
                context.Books.Add(book3);
                context.Books.Add(book4);
                context.Books.Add(book5);
                context.Books.Add(book6);
                context.Books.Add(book7);
                context.Books.Add(book8);
                context.Books.Add(book9);
                context.Books.Add(book10);
                context.Books.Add(book11);
                context.Books.Add(book12);
                context.Books.Add(book13);
                context.Books.Add(book14);
                context.Books.Add(book15);
                context.Books.Add(book16);
                context.SaveChanges();
            }


            Customer cust1 = new Customer
            {
                FullName= "Memmedli Agasef",
                CreateDate= DateTime.Now.AddDays(-5),
                PhoneNumber="+994552995921",
                Address="Baku,Nizami,Naxcivaski 72",
                Gender="Men"
            };

            Customer cust2 = new Customer
            {
                FullName = "Ehmedov Behruz",
                CreateDate = DateTime.Now.AddDays(-28),
                PhoneNumber = "+994556965575",
                Address = "Tovuz,Qovlar kendi",
                Gender = "Men"
            };
            Customer cust3 = new Customer
            {
                FullName = "Memmedov Teymur",
                CreateDate = DateTime.Now.AddDays(-95),
                PhoneNumber = "+994772456372",
                Address = "Masalli,Hacitepe k",
                Gender = "Men"
            };
        
            Customer cust4 = new Customer
            {
                FullName = "Veliyev Xudaverdi",
                CreateDate = DateTime.Now.AddDays(-16),
                PhoneNumber = "+994502993756",
                Address = "Sumqayit,7 microray",
                Gender = "Men"
            };
    
            Customer cust5 = new Customer
            {
                FullName = "Isgenderov Aynur",
                CreateDate = DateTime.Now.AddDays(-51),
                PhoneNumber = "+994709938282",
                Address = "Gence,Nizami",
                Gender = "Women"
            };

            Customer cust6 = new Customer
            {
                FullName = "Hesenov Ates",
                CreateDate = DateTime.Now.AddDays(-45),
                PhoneNumber = "+9948922121",
                Address = "Baki,Binegedi,Eliaga Shix 21",
                Gender = "Men"
            };
        
            Customer cust7 = new Customer
            {
                FullName = "Baxisov Xamid",
                CreateDate = DateTime.Now.AddDays(-15),
                PhoneNumber = "+994552913425",
                Address = "Baki,Sabuncu, Oskar Efendiyev 1a",
                Gender = "Men"
            };
        
            Customer cust8 = new Customer
            {
                FullName = "Isgenderov Serxan",
                CreateDate = DateTime.Now.AddDays(-102),
                PhoneNumber = "+9945565353",
                Address = "Baki,Ehmedli,Nesreddin Tusi 38",
                Gender = "Men"
            };


            context.Customers.Add(cust1);
            context.Customers.Add(cust2);
            context.Customers.Add(cust3);
            context.Customers.Add(cust4);
            context.Customers.Add(cust5);
            context.Customers.Add(cust6);
            context.Customers.Add(cust7);
            context.Customers.Add(cust8);

            context.SaveChanges();


            Administrator admin = new Administrator
            {
                Login = "Admin",
                Password = "admin",
                FullName = "Memmedli Aga",
                CreateDate = DateTime.Now.AddDays(-309),
                PhoneNumber="+9942995922",
                Address= "Baku,Nizami,Naxcivaski 72",
                Gender="Men"
            };
            context.Administrators.Add(admin);
            context.SaveChanges();


            var rentedBook1 = new List<RentedBook>
            {
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust1.Id,
                    BookId=book1.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(10),
                    Price=(book1.Price/28)*10
                },
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust1.Id,
                    BookId=book5.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(17),
                    Price=(book1.Price/28)*17
                },
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust1.Id,
                    BookId=book1.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(28),
                    Price=(book1.Price/28)*28
                }
            };
            var rentedBook2 = new List<RentedBook>
            {
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust4.Id,
                    BookId=book1.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(4),
                    Price=(book1.Price/28)*4
                },
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust4.Id,
                    BookId=book5.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(7),
                    Price=(book1.Price/28)*7
                },
                new RentedBook
                {
                    AdministratorId=admin.Id,
                    CustomerId=cust4.Id,
                    BookId=book1.Id,
                    TakingDate=DateTime.Now,
                    ReturnDate=DateTime.Now.AddDays(8),
                    Price=(book1.Price/28)*8
                }
            };
            context.RentedBooks.AddRange(rentedBook1);
            context.RentedBooks.AddRange(rentedBook2);
            context.SaveChanges();
        }
    }
}
