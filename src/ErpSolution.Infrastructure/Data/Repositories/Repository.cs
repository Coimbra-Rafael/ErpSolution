
using ErpSolution.Domain.Interfaces;
using ErpSolution.Domain.Shared;

using Microsoft.EntityFrameworkCore;

namespace ErpSolution.Infrastructure.Data.Repositories;

public class Repository<TEntity>(AppDbContext context) : IRepository<TEntity> where TEntity : Entity
{
    private readonly AppDbContext _context = context;

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _context.Set<TEntity>().AddAsync(entity, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _context.Set<TEntity>()
            .FirstAsync(x => x.Id == id, cancellationToken)
            .ConfigureAwait(false);

        _context.Set<TEntity>().Remove(entity);
        
    }

    public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _context.Set<TEntity>().Update(entity);
        return Task.CompletedTask;
    }
}