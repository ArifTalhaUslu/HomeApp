import axios from 'axios';
import { Expense } from '../Models/Expense';

const API_URL = 'https://localhost:1516/api/expenses';

class ExpenseService {
    async create(expense: Expense): Promise<Expense> {
        const response = await axios.post(API_URL, expense);
        return response.data;
    }

    async getAll(): Promise<Expense[]> {
        const response = await axios.get(API_URL);
        return response.data;
    }

    async getById(id: string): Promise<Expense | undefined> {
        const response = await axios.get(`${API_URL}/${id}`);
        return response.data;
    }

    async update(id: string, updatedExpense: Expense): Promise<Expense | undefined> {
        const response = await axios.put(`${API_URL}/${id}`, updatedExpense);
        return response.data;
    }

    async delete(id: string): Promise<boolean> {
        const response = await axios.delete(`${API_URL}/${id}`);
        return response.status === 204;
    }
}

export const expenseService = new ExpenseService();
