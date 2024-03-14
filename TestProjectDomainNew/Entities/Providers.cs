namespace TestProjectDomainNew.Entities;

public class Providers
{
    public int Id { get; set; }
    public string Initials { get; set; }
    public Delivery Delivery { get; set; }
}