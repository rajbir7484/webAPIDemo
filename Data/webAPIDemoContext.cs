using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webAPIDemo.Models;

namespace webAPIDemo.Data
{
    public class webAPIDemoContext : DbContext
    {
        public webAPIDemoContext (DbContextOptions<webAPIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<webAPIDemo.Models.Todoitem> Todoitem { get; set; }
    }
}
