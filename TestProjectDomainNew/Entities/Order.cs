namespace TestProjectDomainNew.Entities;

public class Order
{
    public int Id { get; set; }
    public Employee Employee { get; set; }
    public Client Client { get; set; }
    public ListOfOrders ListOfOrders { get; set; }
    public int ClientId { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }
}