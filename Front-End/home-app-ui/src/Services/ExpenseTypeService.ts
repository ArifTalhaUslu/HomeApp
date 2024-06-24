import axios from 'axios';
import { ExpenseType } from '../Models/ExpenseType';

const API_URL = 'https://localhost:1516/api/expenseTypes';

class ExpenseTypeService {
    async create(expenseType: ExpenseType): Promise<ExpenseType> {
        const response = await axios.post(API_URL, expenseType);
        return response.data;
    }

    async getAll(): Promise<ExpenseType[]> {
        const response = await axios.get(API_URL);
        return response.data;
    }

    async getById(id: string): Promise<ExpenseType | undefined> {
        const response = await axios.get(`${API_URL}/${id}`);
        return response.data;
    }

    async update(id: string, updatedExpenseType: ExpenseType): Promise<ExpenseType | undefined> {
        const response = await axios.put(`${API_URL}/${id}`, updatedExpenseType);
        return response.data;
    }

    async delete(id: string): Promise<boolean> {
        const response = await axios.delete(`${API_URL}/${id}`);
        return response.status === 204;
    }
}

export const expenseTypeService = new ExpenseTypeService();
