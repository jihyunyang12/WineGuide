using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WineProvider.Models;

namespace WineProvider.Classes
{
    public class WineContext: DbContext
    {
        public WineContext(DbContextOptions<WineContext> opt): base(opt)
        {

        }

        public DbSet<WineDataModel> WineDataModels { get; set; }
    }
}
