using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.Abstract;

public interface IExpenseRepository : IGenericRepository<Expense>
{
    public List<Expense> GetAllByTypeId(int HarcamaTip);
}
