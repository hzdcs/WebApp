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
                if (todoItemList == null )
                {
                    todoItemList= new List<TodoItem>();
                }
                return todoItemList;
            }
        }

        public TodoItem GetTodoItem()
        {
            return TodoItemList.ToArray();
        }

        public TodoItem GetTodo(int id)
        {
            if (!(TodoItemList.Id == id))
            {
                return null;
            }
            return TodoItemList;
        }

        public void updateTodo(TodoItem item)
        {
            TodoItemList = item;
            return TodoItemList();
        }

        public void insertTodo(TodoItem item)
        {
            TodoItemList.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        public void deleteTodo(TodoItem item)
        {
            if (_context.TodoItem == null)
            {
                return NotFound();
            }
            var todoItem = await _context.TodoItem.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
