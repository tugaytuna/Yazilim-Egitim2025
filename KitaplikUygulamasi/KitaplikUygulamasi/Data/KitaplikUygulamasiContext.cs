using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KitaplikUygulamasi.Models;

namespace KitaplikUygulamasi.Data
{
    public class KitaplikUygulamasiContext : DbContext
    {
        public KitaplikUygulamasiContext (DbContextOptions<KitaplikUygulamasiContext> options)
            : base(options)
        {
        }

        public DbSet<KitaplikUygulamasi.Models.Kitap> Kitap { get; set; } = default!;
    }
}
