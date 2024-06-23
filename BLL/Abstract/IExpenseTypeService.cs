using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract;

public interface IExpenseTypeService
{
    public List<ExpenseType> GetList();
    public ExpenseType GetById(int id);
    public bool Add(ExpenseType expense);
    public bool Update(ExpenseType expense); 
    public bool Delete(int id);
}
