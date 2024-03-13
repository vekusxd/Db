namespace TestProjectDomainNew.Entities;

public class Loyality
{
    public int Id { get; set; }
    public int Discount { get; set; }

    public Client Client { get; set; }
}