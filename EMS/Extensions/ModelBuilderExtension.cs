using DemoDotNetCore.Models;
using EMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DemoDotNetCore.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder) {

            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Name = "John Doe",
                        Email = "johndoe@gmail.com",
                        Id = 1001,
                        Department = Department.HR
                    },
                    new Employee
                    {
                        Name = "dennis louis",
                        Email = "dennislouis@gmail.com",
                        Id = 1021,
                        Department = Department.IT
                    }
                );

        }
    }
}
