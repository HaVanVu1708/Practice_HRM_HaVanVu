using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HRM_PracticeHaVanVu.Models;

namespace HRM_PracticeHaVanVu.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HRMDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<HRMDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                   new Employee
                   {
                       Name = "Ha Van Vu",
                       Gender = "Nam",
                       Birthday = "01/01/2021",
                       Address = "Ha Noi",
                       PhoneNumber = "0972985339"
                   },
                   new Employee
                   {
                       Name = "Pham Tung Lam",
                       Gender = "Nu",
                       Birthday = "01/01/2021",
                       Address = "Ha Noi",
                       PhoneNumber = "0972985339"
                   },
                    new Employee
                    {
                        Name = "Nong Phan Manh Hung",
                        Gender = "Nam",
                        Birthday = "01/01/2021",
                        Address = "Ha Noi",
                        PhoneNumber = "0972985339"
                    },
                     new Employee
                     {
                         Name = "Do THi Chan Hoa",
                         Gender = "NU",
                         Birthday = "01/01/2021",
                         Address = "Ha Noi",
                         PhoneNumber = "0972985339"
                     },
                      new Employee
                      {
                          Name = "Do Huu Con",
                          Gender = "Nam",
                          Birthday = "01/01/2021",
                          Address = "Ha Noi",
                          PhoneNumber = "0972985339"
                      }
                   );

                context.SaveChanges();
            }
        }
    }
}
