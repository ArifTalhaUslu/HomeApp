import { ExpenseType } from './ExpenseType';

export interface Expense {
    id?: string;
    name: string;
    cost: number;
    expenseType: ExpenseType;
}