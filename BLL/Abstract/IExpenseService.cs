using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract;

public interface IExpenseService
{
    public List<Expense> GetList();
    public Expense GetById(Guid id);
    public bool Add(Expense expense);
    public bool Update(Expense expense);
    public bool Delete(Guid id);
}
