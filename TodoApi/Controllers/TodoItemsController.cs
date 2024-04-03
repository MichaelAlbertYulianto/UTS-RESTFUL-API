using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Expressions;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/Guru")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TodoItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<bool> GetTodoItems()
        {
            // return await _context.Guru.ToListAsync();
            return true;
        }

        [HttpGet("{nip}")]
        public async Task<bool> GetTodoItem(long id)
        {
            // var todoItem = await _context.Guru.FindAsync(id);

            // if (todoItem == null)
            // {
            //     return NotFound();
            // }

            // return todoItem;
            return true;
        }


        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{nip}")]
        public async Task<bool> PutTodoItem(long id, Users todoItem)
        {
            // if (id != todoItem.id)
            // {
            //     return BadRequest();
            // }

            // _context.Entry(todoItem).State = EntityState.Modified;

            // try
            // {
            //     await _context.SaveChangesAsync();
            // }
            // catch (DbUpdateConcurrencyException)
            // {
            //     if (!TodoItemExists(id))
            //     {
            //         return NotFound();
            //     }
            //     else
            //     {
            //         throw;
            //     }
            // }

            // return NoContent();
            return true;
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<bool> PostTodoItem(Users todoItem)
        {
            // _context.Guru.Add(todoItem);
            // await _context.SaveChangesAsync();

            // // return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            // return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.id }, todoItem);
            return true;
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{nip}")]
        public async Task<bool> DeleteTodoItem(long id)
        {
            // var todoItem = await _context.Guru.FindAsync(id);
            // if (todoItem == null)
            // {
            //     return NotFound();
            // }

            // _context.Guru.Remove(todoItem);
            // await _context.SaveChangesAsync();

            // return NoContent();
            return true;
        }

        private bool TodoItemExists(long id)
        {
            return _context.Users.Any(e => e.id == id);
        }
    }
}
