namespace TestProjectDomainNew.Entities;

public class ListOfOrders
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public ICollection<Dishes> Dishes { get; set; } = [];
    public Order Order { get; set; }
}