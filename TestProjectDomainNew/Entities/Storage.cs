namespace TestProjectDomainNew.Entities;

public class Storage
{
    public int Id { get; set; }
    public Products Products { get; set; }
    public double Price { get; set; }
    public int Remainder { get; set; }
}