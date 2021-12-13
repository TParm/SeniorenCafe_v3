using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Models;


namespace app.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoleItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public RoleItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/RoleItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleItem>>> GetRoleItems()
        {
            return await _context.RoleItems.ToListAsync();
        }

        // GET: api/RoleItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleItem>> GetRoleItem(long id)
        {
            var roleItem = await _context.RoleItems.FindAsync(id);

            if (roleItem == null)
            {
                return NotFound();
            }

            return roleItem;
        }

        // PUT: api/RoleItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleItem(long id, RoleItem roleItem)
        {
            if (id != roleItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(roleItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleItemExists(id))
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

        // POST: api/RoleItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoleItem>> PostRoleItem(RoleItem roleItem)
        {
            _context.RoleItems.Add(roleItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleItem", new { id = roleItem.Id }, roleItem);
        }

        // DELETE: api/RoleItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleItem(long id)
        {
            var roleItem = await _context.RoleItems.FindAsync(id);
            if (roleItem == null)
            {
                return NotFound();
            }

            _context.RoleItems.Remove(roleItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleItemExists(long id)
        {
            return _context.RoleItems.Any(e => e.Id == id);
        }
    }
}
