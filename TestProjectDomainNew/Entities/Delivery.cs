namespace TestProjectDomainNew.Entities;

public class Delivery
{
    public int Id { get; set; }
    public Providers Providers { get; set; }
    public string Date { get; set; }
}