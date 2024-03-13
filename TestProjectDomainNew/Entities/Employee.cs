namespace TestProjectDomainNew.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Initials { get; set; }
    public Order Order { get; set; }
    public int RoleId { get; set; }
    public RoleEmployees Role { get; set; }
}