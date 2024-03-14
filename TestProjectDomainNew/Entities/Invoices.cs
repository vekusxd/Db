namespace TestProjectDomainNew.Entities;

public class Invoices
{
    public int Id { get; set; }
    public int DeliveryId { get; set; }
    public ICollection<Delivery> Deliveries { get; set; }
    public ICollection<Products> Products { get; set; }
    public int ProductId { get; set; }
    public int Count { get; set; }
}