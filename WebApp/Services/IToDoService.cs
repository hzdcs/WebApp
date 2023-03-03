using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Services
{
    public interface IToDoService
    {
        TodoItem getTodo(int id);
        TodoItem[] getTodo();
        void insert(TodoItem todo);
        void update(TodoItem todo);
        void delete(TodoItem todo);
    }
}
