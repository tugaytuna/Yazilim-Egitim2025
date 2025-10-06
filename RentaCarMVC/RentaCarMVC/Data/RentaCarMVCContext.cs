using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaCarMVC.Models;

namespace RentaCarMVC.Data
{
    public class RentaCarMVCContext : DbContext
    {
        public RentaCarMVCContext (DbContextOptions<RentaCarMVCContext> options)
            : base(options)
        {
        }

        public DbSet<RentaCarMVC.Models.Arac> Arac { get; set; } = default!;
    }
}
