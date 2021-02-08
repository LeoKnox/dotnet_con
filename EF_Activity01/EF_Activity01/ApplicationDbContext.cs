using Microsoft.EntityFrameworkCore;
using System;

namespace EF_Activity01
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            // class library for use later.
        }
    }
}
