using Microsoft.EntityFrameworkCore;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew;

public class CrmDbContext : DbContext
{
    public DbSet<ProductCategories> Categories { get; set; }
    public DbSet<CategoryDishes> CategoryDishes { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Dishes> Dishes { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Ingredients> Ingredients { get; set; }
    public DbSet<Invoices> Invoices { get; set; }
    public DbSet<ListOfOrders> ListOfOrders { get; set; }
    public DbSet<Loyality> Loyalities { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Providers> Providers { get; set; }
    public DbSet<RoleEmployees> RoleEmployees { get; set; }
    public DbSet<Storage> Storages { get; set; }
}