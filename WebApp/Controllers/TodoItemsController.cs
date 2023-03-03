using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        [FromServices]
        public ITodoService TodoService { get; set; }

        // GET: api/TodoItems
        [HttpGet]
        public IEnumerable<TodoItem> GetTodoItem()
        {
            return TodoService.GetAll();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public TodoItem GetTodo(int id)
        {
            return TodoService.GetTodo(id);
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public void PutTodoItem(int id, TodoItem todoItem)
        {
            TodoService.updateTodo(todoItem);
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostTodoItem(TodoItem todoItem)
        {
            TodoService.insertTodo(todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public void DeleteTodoItem(int id)
        {
            TodoService.deleteTodo(id);
        }

        private bool TodoItemExists(int id)
        {
            return true;
        }
    }
}
