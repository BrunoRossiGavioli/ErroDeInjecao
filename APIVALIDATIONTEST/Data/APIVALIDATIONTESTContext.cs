using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIVALIDATIONTEST.Models;

namespace APIVALIDATIONTEST.Data
{
    public class APIVALIDATIONTESTContext : DbContext
    {
        public APIVALIDATIONTESTContext (DbContextOptions<APIVALIDATIONTESTContext> options)
            : base(options)
        {
        }

        public DbSet<APIVALIDATIONTEST.Models.PessoaModel> PessoaModel { get; set; }
    }
}
