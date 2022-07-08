using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Prajwal Patil 
using OMRWebApp.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace OMRWebApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeDALOMR: DbContext
    {
        public DbSet<EmployeeBOL> emp { get; set; }//Prajwal Patil 
        public EmployeeDALOMR() : base("WebDataCon")
        {
        }
    }
}
