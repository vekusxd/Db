namespace TestProjectDomainNew.Entities;

public class Client
{
    public int Id { get; set; }
    public string Initials { get; set; }
    public Loyality Loyality{ get; set; }
    public Order Order { get; set; }
}