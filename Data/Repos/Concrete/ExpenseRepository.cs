using DataAccess.Context;
using DataAccess.Repos.Abstract;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repos.Concrete;

public class ExpenseRepository : GenericRepository<Expense>, IExpenseRepository
{
    public ExpenseRepository(HomeDbContext dbContext) : base(dbContext)
    {
    }

    public HomeDbContext HomeContext { get { return (HomeDbContext)dbContext; } }
    public List<Expense> GetAllByTypeId(int HarcamaTipId)
    {
        using (HomeContext)
        {
            return HomeContext.Expense.Include(x => x.ExpenseType).Where(d => d.Id == HarcamaTipId).ToList();
        }
    }
}
