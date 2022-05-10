﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cs_ProCatApi.Models
{
    public class CodAuthDbContext : IdentityDbContext<IdentityUser>
    {
        public CodAuthDbContext(DbContextOptions<CodAuthDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
