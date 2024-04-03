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
    [Route("userpost")]
    [ApiController]
    public class Userpost : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Userpost(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<CustomUsers>> GetTodoItems()
        {
            if (_context.Users == null)
            {
                return NotFound();
            }

            var todoItem = await _context.Users.ToListAsync();
            CustomUsers customusers = new CustomUsers(await _context.Users.ToListAsync(),await _context.Posts.ToListAsync());
            if (todoItem == null)
            {
                return NotFound();
            }
            return customusers;
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Guru>> GetTodoItem(long id)
        // {
        //     var todoItem = await _context.Guru.FindAsync(id);

        //     if (todoItem == null)
        //     {
        //         return NotFound();
        //     }

        //     return todoItem;
        // }

        // // GET: api/TodoItems/5
        // // [HttpGet("{offset}/{limit}")]
        // // public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem(int offset, int limit)
        // // {

        // //     if (_context.TodoItems == null)
        // //     {
        // //         return NotFound();
        // //     }

        // //     IQueryable<TodoItem> query = _context.TodoItems.AsQueryable();
        // //     int start = offset * limit;
        // //     query = query.OrderByDescending(TodoItem => TodoItem.Id).Skip(start).Take(limit);

        // //     var todoItem = await query.ToListAsync();

        // //     if(todoItem == null){
        // //     return NotFound();
        // //     }
        // //     return todoItem;
        // // }

        // // [HttpGet("{Count}/{offset}/{tes}")]
        // // public async Task<ActionResult<TodoItemCustom>> GetTodoItem(int offset, int limit, int tes)
        // // {
        // //     if (_context.TodoItems == null)
        // //     {
        // //         return NotFound();
        // //     }

        // //     var todoItem = await _context.TodoItems.ToListAsync();
        // //     int count = todoItem.Count();
        // //     TodoItemCustom todoitemcustom = new TodoItemCustom(count, todoItem);
        // //     if (todoItem == null)
        // //     {
        // //         return NotFound();
        // //     }
        // //     return todoitemcustom;
        // // }

        // // PUT: api/TodoItems/5
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutTodoItem(long id, Guru todoItem)
        // {
        //     if (id != todoItem.id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(todoItem).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!TodoItemExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // // POST: api/TodoItems
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPost]
        // public async Task<ActionResult<Guru>> PostTodoItem(Guru todoItem)
        // {
        //     _context.Guru.Add(todoItem);
        //     await _context.SaveChangesAsync();

        //     // return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //     return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.id }, todoItem);
        // }

        // // DELETE: api/TodoItems/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteTodoItem(long id)
        // {
        //     var todoItem = await _context.Guru.FindAsync(id);
        //     if (todoItem == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Guru.Remove(todoItem);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        private bool TodoItemExists(long id)
        {
            return _context.Users.Any(e => e.id == id);
        }
    }
}
