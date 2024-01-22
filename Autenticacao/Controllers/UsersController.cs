using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Autenticacao.Data;
using Autenticacao.Models;

namespace Autenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AuthContext _context;

        public UsersController(AuthContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Getusuarios()
        {
            return await _context.usuarios.ToListAsync();
        }
                

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.usuarios.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
       
        private bool UserExists(int id)
        {
            return _context.usuarios.Any(e => e.Id == id);
        }
    }
}
