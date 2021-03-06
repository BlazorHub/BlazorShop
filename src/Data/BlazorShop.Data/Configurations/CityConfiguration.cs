﻿namespace BlazorShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    using static Common.ModelConstants;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> city)
        {
            city
                .Property(c => c.Name)
                .HasMaxLength(CityNameMaxLength)
                .IsRequired();

            city
                .HasOne(c => c.Region)
                .WithMany(r => r.Cities)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
