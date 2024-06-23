using DataAccess.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public interface IUnitOfWork : IDisposable
{
    IExpenseRepository ExpenseRepository { get; }
    IExpenseTypeRepository ExpenseTypeRepository { get; }

}
