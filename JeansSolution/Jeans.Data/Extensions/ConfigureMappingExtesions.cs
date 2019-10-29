using Jeans.Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeans.Data.Extensions
{
    public static class ConfigureMappingExtesions
    {
        public static void Mapping(this ModelBuilder builder)
        {
            builder.Entity<Users>(m =>
            {
                m.ToTable("users");
                m.HasKey(t => t.Id);
                m.Property(t => t.UserName).IsRequired().HasMaxLength(16);
                m.Property(t => t.Password).IsRequired().HasMaxLength(64);
                m.Property(t => t.Name).HasMaxLength(32);
                m.Property(t => t.QQ).HasMaxLength(16);
                m.Property(t=>t.Email).HasMaxLength(128);
            });
        }
    }
}
