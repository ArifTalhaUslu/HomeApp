using BLL.Abstract;
using DataAccess;
using DataAccess.Context;
using Entity.Models;

namespace BLL.Concrete;

public class ExpenseService : IExpenseService
{
    public List<Expense> GetList()
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseRepository.GetAll().ToList();
        }
    }
    public Expense GetById(int id)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseRepository.GetById(id);
        }
    }
    public bool Add(Expense expense)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseRepository.Add(expense) > 0;
        }
    }
    public bool Update(Expense expense)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseRepository.Update(expense) > 0;
        }
    }
    public bool Delete(int id)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseRepository.Delete(id) > 0;
        }
    }
}
