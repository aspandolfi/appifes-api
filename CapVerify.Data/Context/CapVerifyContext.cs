using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapVerify.Data.Context
{
    public class CapVerifyContext : DbContext
    {
        public CapVerifyContext(DbContextOptions<CapVerifyContext> options)
            : base(options)
        {

        }


    }
}
