using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("name=EmployeeContext")
        {

        }
        public DbSet<Employee> EmpList{ get; set; }
        public DbSet<State> StateList { get; set; }
        public DbSet<City> CityList { get; set; }

    }
}