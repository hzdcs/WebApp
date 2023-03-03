using WebApp.Models;

namespace WebApp.Services
{
    public interface ITodoService
    {
        TodoItem GetTodo(int id);
        IEnumerable<TodoItem> GetAll();

        void deleteTodo(int id);
        void insertTodo(TodoItem item);
        void updateTodo(TodoItem item);
    }
}
