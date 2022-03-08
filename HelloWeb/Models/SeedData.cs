using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HelloWeb.Data;
using System;
using System.Linq;

namespace HelloWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Title = "Mike",
                        BirthDate = DateTime.Parse("2001-2-12"),
                    },

                    new Student
                    {
                        Title = "Beth",
                        BirthDate = DateTime.Parse("1999-3-9"),
                    },

                    new Student
                    {
                        Title = "Shaq",
                        BirthDate = DateTime.Parse("1995-1-6"),
                    },

                   new Student
                   {
                       Title = "Lily",
                       BirthDate = DateTime.Parse("2002-7-5"),
                   }
                );
                context.SaveChanges();
            }
        }
    }
}