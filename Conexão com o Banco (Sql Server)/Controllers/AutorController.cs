using System.Collections.Generic;
using System.Threading.Tasks;
using Bd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {

        bdContext _context = new bdContext();

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get() {

            var autores = await _context.Autor.ToListAsync();

            if(autores == null) {
                return NotFound();
            }
            return autores;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Autor>> Get(int id) {

            var autor = await _context.Autor.FindAsync(id);

            if(autor == null) {
                return NotFound();
            }
            return autor;
        }

        [HttpPost]
        public async Task<ActionResult<Autor>> Post(Autor autor) {

            try {
                await _context.AddAsync(autor);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException) {
                throw;
            }
            return autor;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Autor autor) {

            if(id != autor.Idautor) {
                return BadRequest();
            }

            _context.Entry(autor).State = EntityState.Modified;

            try{
                await _context.SaveChangesAsync();
            }
            catch {
                var autor_valido = await _context.Autor.FindAsync(id);

                if(autor_valido == null) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Autor>> Delete(int id){
            
            var autor = await _context.Autor.FindAsync(id);

            if(autor == null){
                return BadRequest();
            }

            _context.Autor.Remove(autor);
            await _context.SaveChangesAsync();

            return autor;
        }
    }
}