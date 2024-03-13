namespace TestProjectDomainNew.Entities;

public class Dishes
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public string Recipe { get; set; }
    public ICollection<CategoryDishes> CategoryDishes { get; set; }
    public ICollection<Ingredients> Ingredients { get; set; }
    public ListOfOrders ListOfOrders { get; set; }
}

