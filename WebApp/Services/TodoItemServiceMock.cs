using WebApp.Models;

namespace WebApp.Services
{
    public class TodoItemServiceMock : ITodoService
    {
        public void deleteTodo(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodoItem()
        {
            throw new NotImplementedException();
        }

        public void insertTodo(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void updateTodo(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
