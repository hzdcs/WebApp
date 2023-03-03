using WebApp.Models;

namespace WebApp.Services
{
    public class TodoListByList : ITodoService
    {
        private List<TodoItem> todoItemsList;

        public List<TodoItem> TodoItemsList
        {
            get
            {
                if (todoItemsList == null)
                {
                    todoItemsList = new List<TodoItem>();
                }
                return todoItemsList;
            }
        }

        public void deleteTodo(int id)
        {
            var tmpItem = TodoItemsList.FirstOrDefault(item=> item.Id == id);
            TodoItemsList.Remove(tmpItem);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItemsList;
        }

        public TodoItem GetTodo(int id)
        {
            var tmpItem = TodoItemsList.FirstOrDefault(item => item.Id == id);
            return tmpItem;
        }

        public void insertTodo(TodoItem item)
        {
            TodoItemsList.Add(item);
        }

        public void updateTodo(TodoItem item)
        {
            GetAll();
        }
    }
}
