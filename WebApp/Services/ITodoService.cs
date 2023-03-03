using WebApp.Models;

namespace WebApp.Services
{
    public interface ITodoService
    {
        TodoItem GetTodo(int id);
        TodoItem GetTodoItem();
        IEnumerable<TodoItem> GetAll();

        void deleteTodo(TodoItem item);
        void insertTodo(TodoItem item);
        void updateTodo(TodoItem item);
    }
}
