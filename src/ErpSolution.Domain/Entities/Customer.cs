using ErpSolution.Domain.Shared;

namespace ErpSolution.Domain.Entities;

public class Customer : Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public bool Active { get; private set; }

    public Customer(string name, string email, string phone, bool active = true)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Active = active;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = DateTime.UtcNow;
    }
    public void UpdateEntity(string name, string email, string phone, bool active)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Active = active;
        UpdatedOn = DateTime.UtcNow;
    } 
    public void Deactivate()
    {
        Active = false;
        UpdatedOn = DateTime.UtcNow;
    }
}