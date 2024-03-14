namespace TestProjectDomainNew.Entities;

public class ProductCategories
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Products Products { get; set; }
}