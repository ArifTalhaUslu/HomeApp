using DataAccess.Context;
using DataAccess.Repos.Abstract;
using Entity.Models;

namespace DataAccess.Repos.Concrete;

public class ExpenseTypeRepository : GenericRepository<ExpenseType>, IExpenseTypeRepository
{
    public ExpenseTypeRepository(HomeDbContext dbContext) : base(dbContext)
    {
    }

    public HomeDbContext HomeContext { get { return (HomeDbContext)dbContext; } }

}
