using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Data;
using TodoListAPI.Models.TodoWork;

namespace TodoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoWorksController : ControllerBase
    {
        private readonly TodoListDbContext _context;

        public TodoWorksController(TodoListDbContext context)
        {
            _context = context;
        }

        // GET: api/TodoWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoWork>>> GetTodoWorks()
        {
          if (_context.TodoWorks == null)
          {
              return NotFound();
          }
            return await _context.TodoWorks.ToListAsync();
        }

        // GET: api/TodoWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoWork>> GetTodoWork(int id)
        {
          if (_context.TodoWorks == null)
          {
              return NotFound();
          }
            var todoWork = await _context.TodoWorks.FindAsync(id);

            if (todoWork == null)
            {
                return NotFound();
            }

            return todoWork;
        }

        // PUT: api/TodoWorks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoWork(int id, TodoWork todoWork)
        {
            if (id != todoWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoWorkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoWorks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoWorkModel>> PostTodoWork(TodoWorkModel todoWorkModel)
        {
            var todoWork = new TodoWork
            {
                Title = todoWorkModel.Title,
                Body = todoWorkModel.Body
            };
          if (_context.TodoWorks == null)
          {
              return Problem("Entity set 'TodoListDbContext.TodoWorks'  is null.");
          }
            _context.TodoWorks.Add(todoWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoWork", new { id = todoWork.Id }, todoWork);
        }

        // DELETE: api/TodoWorks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoWork(int id)
        {
            if (_context.TodoWorks == null)
            {
                return NotFound();
            }
            var todoWork = await _context.TodoWorks.FindAsync(id);
            if (todoWork == null)
            {
                return NotFound();
            }

            _context.TodoWorks.Remove(todoWork);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoWorkExists(int id)
        {
            return (_context.TodoWorks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
