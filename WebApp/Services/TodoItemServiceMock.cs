using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Services
{
    public class TodoItemServiceMock : ITodoService
    {
        private List<TodoItem> todoItemList;

        public List<TodoItem> TodoItemList
        {
            get
            {
                return new List<TodoItem>();
            }
        }

        public TodoItem GetTodoItem()
        {
            return new TodoItem();
        }

        public TodoItem GetTodo(int id)
        {
            return new TodoItem();
        }

        public void updateTodo(TodoItem item)
        {
        }

        public void insertTodo(TodoItem item)
        {
        }

        public void deleteTodo(TodoItem item)
        {
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return new List<TodoItem>();
        }
    }
}
