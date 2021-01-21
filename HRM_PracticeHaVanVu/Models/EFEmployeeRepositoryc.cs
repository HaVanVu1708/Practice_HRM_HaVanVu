using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_PracticeHaVanVu.Models
{
    public class EFEmployeeRepositoryc : IEmployeeRepository
    {
        private HRMDbContext context;

        public EFEmployeeRepositoryc(HRMDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
