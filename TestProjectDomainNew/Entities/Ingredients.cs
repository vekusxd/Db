namespace TestProjectDomainNew.Entities;

public class Ingredients
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Dishes Dishes { get; set; }
    public int Count { get; set; }
}