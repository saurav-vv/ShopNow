using Microsoft.EntityFrameworkCore;
using ShopNow.DataAccessLayer.DataSet.EntityModel;

namespace ShopNow.DataAccessLayer
{
    public class ShopNowDBContext :DbContext
    {
        public ShopNowDBContext(DbContextOptions<ShopNowDBContext> options):base(options)
        {

        }

        public DbSet<UsersCategory> UsersCategories { get; set; }
        public DbSet<SignUpEntity> SignUpEntities { get; set; }

        //public override Task<int> SaveChangesAsync(CancellationToken token)
        //{
        //    ProcessSave();
        //    return base.SaveChangesAsync(token);
        //}

        //private void ProcessSave()
        //{
        //    var currentTime = DateTimeOffset.UtcNow;
        //    foreach (var item in ChangeTracker.Entries().Where(x => x.State == EntityState.Added && x.Entity is Entity))
        //    {
        //        var entity = item.Entity as Entity;
        //        entity.CreatedDate = currentTime;
        //        entity.UpdatedDate = currentTime;

        //    }

        //    foreach (var item in ChangeTracker.Entries().Where(x => x.State == EntityState.Modified && x.Entity is Entity))
        //    {
        //        var entity = item.Entity as Entity;
        //        entity.UpdatedDate = currentTime;
        //        item.Property(nameof(entity.CreatedDate)).IsModified = false;
        //    }
        //}
    }
}
