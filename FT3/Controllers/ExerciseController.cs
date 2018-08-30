using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FT3.Models;

namespace FT3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly WorkoutContext _context;

        public ExerciseController(WorkoutContext context)
        {
            _context = context;
        }

        // GET: api/Exercise
        [HttpGet]
        public IEnumerable<Exercise> GetExercise()
        {
            return _context.Exercise.ToArray<Exercise>();
        }

        // GET: api/Exercise/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExercise([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var exercise = await _context.Exercise.FindAsync(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        // PUT: api/Exercise/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExercise([FromRoute] int id, [FromBody] Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != exercise.exerciseID)
            {
                return BadRequest();
            }

            _context.Entry(exercise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExerciseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(exercise);
        }

        // POST: api/Exercise
        [HttpPost]
        public async Task<IActionResult> PostExercise([FromBody] Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Exercise.Add(exercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercise", new { id = exercise.exerciseID }, exercise);
        }

        // DELETE: api/Exercise/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercise([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var exercise = await _context.Exercise.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }

            _context.Exercise.Remove(exercise);
            await _context.SaveChangesAsync();

            return Ok(exercise);
        }

        private bool ExerciseExists(int id)
        {
            return _context.Exercise.Any(e => e.exerciseID == id);
        }
    }
}