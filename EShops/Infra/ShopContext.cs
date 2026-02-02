using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ShopContext:DbContext
    {
        //create Constructure
    public ShopContext(DbContextOptions<ShopContext>options):
            base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().HasData(
                new Store()
                {
                    StoreId = 1,
                    StoreName = "ABC",
                    Address = "New Delhi",
                    EmailId="abc@gmail.com",
                    mobileNo = "98123756"
                });
            modelBuilder.Entity<MainCategory>().HasData(
                new MainCategory()
                {
                    MainCategoryId = 1,
                    MainCategoryName="Eloctronic",
                },
                 new MainCategory()
                 {
                    MainCategoryId = 2,
                    MainCategoryName = "Kitchen",
                },
                 new MainCategory()
                 {
                     MainCategoryId = 3,
                     MainCategoryName = "Books",
                 },
                 new MainCategory()
                 {
                     MainCategoryId = 4,
                     MainCategoryName = "Cloths",
                 });
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory()
                {
                    SubCategoryId=1,
                    MainCategoryId=1,
                    SubCategoryName="Computer"
                },
                new SubCategory()
                {
                    SubCategoryId = 2,
                    MainCategoryId = 1,
                    SubCategoryName = "Phone"
                },
                new SubCategory()
                {
                    SubCategoryId = 3,
                    MainCategoryId = 2,
                    SubCategoryName = "Plates"
                },
                new SubCategory()
                {
                    SubCategoryId = 4,
                    MainCategoryId = 2,
                    SubCategoryName = "Gilash"
                },
                new SubCategory()
                {
                    SubCategoryId = 5,
                    MainCategoryId = 3,
                    SubCategoryName = "Math"
                },
                new SubCategory()
                {
                    SubCategoryId = 6,
                    MainCategoryId = 3,
                    SubCategoryName = "English"
                },
                new SubCategory()
                {
                    SubCategoryId = 7,
                    MainCategoryId = 4,
                    SubCategoryName = "Shirt"
                },
                new SubCategory()
                {
                    SubCategoryId = 8,
                    MainCategoryId = 4,
                    SubCategoryName = "Pent"
                });

        }
        //For all classes we create db set property
        public DbSet<DispatchAgency> dispatchAgencies { get; set; }
        public DbSet<MainCategory> mainCategories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderDispatch> orderDispatches { get; set; }
        public DbSet<OrderPayments> OrderPayments { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<UserMaster> users { get; set; }

    }
}
