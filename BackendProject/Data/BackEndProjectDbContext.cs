using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Models;
using Microsoft.EntityFrameworkCore;
namespace BackendProject.Data
{
    public class BackEndProjectDbContext:DbContext
    {
        public BackEndProjectDbContext()
        {
        }

        public BackEndProjectDbContext(DbContextOptions<BackEndProjectDbContext> options) : base(options) { }

        public DbSet<HomeHeroSlider> HomeHeroSlider { get; set; }

        public DbSet<AboutUsText> AboutUsTexts { get; set; }

        public DbSet<BlogCard> BlogCards { get; set; }

        public DbSet<OurBlog> OurBlogs { get; set; }

        public DbSet<OurPortfolio> OurPortfolios { get; set; }

        public DbSet<Promo> Promos { get; set; }

        public DbSet<PromoBlock> PromoBlocks { get; set; }

        public DbSet<PromoButton> PromoButtons { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServicesCard> ServicesCards { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<TeamTwoText> TeamTwoTexts { get; set; }

        public DbSet<TeamTwoCard> teamTwoCards { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<TestimonialCard> TestimonialCards { get; set; }

       
    }
}
