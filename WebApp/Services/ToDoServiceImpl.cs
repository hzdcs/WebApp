using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using WebApp.Data;
using WebApp.Interfaces;
using WebApp.Models;

namespace WebApp.Services
{
    public class ToDoServiceImpl : IToDoService
    {
        TodoItem[] IToDoService.getTodo()
        {
            throw new NotImplementedException();
        }

        TodoItem IToDoService.getTodo(int id)
        {
            throw new NotImplementedException();
        }

        void IToDoService.insert(TodoItem todo)
        {
            throw new NotImplementedException();
        }

        void IToDoService.delete(TodoItem todo)
        {
            throw new NotImplementedException();
        }

        void IToDoService.update(TodoItem todo)
        {
            throw new NotImplementedException();
        }
    }
}
