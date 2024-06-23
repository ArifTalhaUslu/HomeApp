namespace Entity.Models;

public class Expense : BaseEntity
{
    public required float Cost { get; set; }
    public required DateTime ExpenseDate { get; set; }
    public required ExpenseType ExpenseType { get; set; }
}
