using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamworkPracticeContext context = new TeamworkPracticeContext();
            context.SaveChanges();
            if (context.Books.Count() != 0)
            {
                context.Books.Add(new Book
                {
                    Title = "C# Basics",

                });

                context.SaveChanges();

                context.Authors.Add(new Author { FirstName = "Pesho", LastName = "Peshov" });

                context.SaveChanges();
            }

        }
    }
}
