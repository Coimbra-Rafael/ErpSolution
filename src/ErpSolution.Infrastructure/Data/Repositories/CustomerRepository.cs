
using ErpSolution.Domain.Entities;
using ErpSolution.Domain.Interfaces;

namespace ErpSolution.Infrastructure.Data.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    
    public Task<IEnumerable<Customer>> GetNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<Customer?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Customer?> GetByPhoneAsync(string phone)
    {
        throw new NotImplementedException();
    }
    public Task<bool> ExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}