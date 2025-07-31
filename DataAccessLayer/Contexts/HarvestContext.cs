using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts
{
    public class HarvestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FURKAN\\SQLEXPRESS;database=DbHarvest;integrated security=true;TrustServerCertificate=true");
        }
        public DbSet<Address> Addresses {  get; set; }
        public DbSet<Contact> Contacts {  get; set; }
        public DbSet<Image> Images {  get; set; }
        public DbSet<Announcement> Announcements {  get; set; }
        public DbSet<Service> Services {  get; set; }
        public DbSet<Team> Teams {  get; set; }

    }
}
