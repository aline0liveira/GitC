using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoWebApiCore.Models
{
    public class ContextDb : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
    }
}
