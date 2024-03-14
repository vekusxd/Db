namespace TestProjectDomainNew.Entities;

public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Storage Storage { get; set; }
    public ProductCategories ProductCategories { get; set; }
    public Invoices Invoices { get; set; }
}