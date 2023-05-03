using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DynamicMask.Module.BusinessObjects;

namespace DynamicMaskEF.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class DynamicMaskEFContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<DynamicMaskEFEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new DynamicMaskEFEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class DynamicMaskEFDesignTimeDbContextFactory : IDesignTimeDbContextFactory<DynamicMaskEFEFCoreDbContext> {
	public DynamicMaskEFEFCoreDbContext CreateDbContext(string[] args) {
		throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		//var optionsBuilder = new DbContextOptionsBuilder<DynamicMaskEFEFCoreDbContext>();
		//optionsBuilder.UseSqlServer("Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DynamicMaskEF");
        //optionsBuilder.UseChangeTrackingProxies();
        //optionsBuilder.UseObjectSpaceLinkProxies();
		//return new DynamicMaskEFEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(DynamicMaskEFContextInitializer))]
public class DynamicMaskEFEFCoreDbContext : DbContext {
	public DynamicMaskEFEFCoreDbContext(DbContextOptions<DynamicMaskEFEFCoreDbContext> options) : base(options) {
	}
	public DbSet<DemoObject> DemoObjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
    }
}
