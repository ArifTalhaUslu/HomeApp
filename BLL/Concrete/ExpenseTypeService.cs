using BLL.Abstract;
using DataAccess;
using DataAccess.Context;
using Entity.Models;

namespace BLL.Concrete;

public class ExpenseTypeService : IExpenseTypeService
{
    public List<ExpenseType> GetList()
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseTypeRepository.GetAll().ToList();
        }
    }
    public ExpenseType GetById(int id)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseTypeRepository.GetById(id);
        }
    }
    public bool Add(ExpenseType expenseType)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseTypeRepository.Add(expenseType) > 0;
        }
    }
    public bool Update(ExpenseType expenseType)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseTypeRepository.Update(expenseType) > 0;
        }
    }
    public bool Delete(int id)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new HomeDbContext()))
        {
            return _unit.ExpenseTypeRepository.Delete(id) > 0;
        }
    }
}
