using Home_Secuirity_Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Secuirity_Presistance.DataBase
{
    public class HomeSecuirtDataBaseContext : DbContext
    {
        public HomeSecuirtDataBaseContext(DbContextOptions<HomeSecuirtDataBaseContext> options) : base(options)  
        {

        }

        public DbSet<User>  Users  { get; set; }
        public DbSet<House>  Houses  { get; set; }
        public DbSet<Device> Devices   { get; set; }
        //  public DbSet<Image> Images  {get ; set }


      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //we can use this to make all Configurations class affect here 
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(HomeSecuirtDataBaseContext).Assembly);

            //or we can use this line to ever Configurations 
            //two is the same
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());


            base.OnModelCreating(modelBuilder);
        }


    }
}
