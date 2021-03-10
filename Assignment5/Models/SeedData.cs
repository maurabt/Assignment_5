using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();
            //migrate when migrations are pending
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //when there are no books added yet
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    //typed out data entries for book database
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 0451419439,
                        Class = "Fiction, Classic",
                        Price = "9.95"
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 0743270755,
                        Class = "Non-Fiction, Biography",
                        Price = "14.58"
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = 0553384611,
                        Class = "Non-Fiction, Biography",
                        Price = "21.54"
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = 0812981254,
                        Class = "Non-Fiction, Biography",
                        Price = "11.61"
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 0812974492,
                        Class = "Non-Fiction, Historical",
                        Price = "13.33"
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = 0804171281,
                        Class = "Fiction, Historical Fiction",
                        Price = "15.95"
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 1455586691,
                        Class = "Non-Fiction, Self-Help",
                        Price = "14.99"
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 1455523023,
                        Class = "Non-Fiction, Self-Help",
                        Price = "21.66"
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = 1591847984,
                        Class = "Non-Fiction, Business",
                        Price = "29.16"
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = 0553393613,
                        Class = "Fiction, Thrillers",
                        Price = "15.03"
                    }
                );
                //saving edits to seeds
                context.SaveChanges();
            }
        }
    }
}
