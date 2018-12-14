using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppSQL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppSQL.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class LoginController : ControllerBase
    {
        private LoginContext _context;
        public LoginController(LoginContext context)
        {
            _context = context;
            if (_context.LoginItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.LoginItems.Add(new LoginItem { UserName = "Aze" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginItem>>> GetLoginItems()
        {
            return await _context.LoginItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LoginItem>> GetLoginItem(long id)
        {
            var todoItem = await _context.LoginItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
        [HttpPost]
        public async Task<ActionResult<LoginItem>> PostLoginItem([FromBody]LoginItem loginItem)
        {
            _context.LoginItems.Add(loginItem);
            //_context.LoginItems.Add(new LoginItem {Id = 458, UserName = "OUHA", AccesToken = "akakakakaka" });
            _context.SaveChanges();
            //_context.LoginItems.Add(loginItem);
            //await _context.SaveChangesAsync();
            return loginItem;
            /*CreatedAtAction("GetLoginItems", new { id = loginItem.Id }, loginItem);*/
        }
    }
}
