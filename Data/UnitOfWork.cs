using DataAccess.Context;
using DataAccess.Repos.Abstract;
using DataAccess.Repos.Concrete;

namespace DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private HomeDbContext _context;
    public UnitOfWork(HomeDbContext context)
    {
        _context = context;
        ExpenseRepository = new ExpenseRepository(_context);
        ExpenseTypeRepository = new ExpenseTypeRepository(_context);
    }

    public IExpenseRepository ExpenseRepository { get; private set; }
    public IExpenseTypeRepository ExpenseTypeRepository { get; private set; }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
