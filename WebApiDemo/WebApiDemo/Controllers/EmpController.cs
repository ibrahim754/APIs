using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public EmpController(ApplicationDBContext _context)
        {
            context = _context;
        }


        [HttpGet] 
        public IActionResult GetEmps  () 
        {
            List<Emp> emps = context.Emps.ToList();

            return Ok(emps);
        }
        [HttpGet("{id:int}")]
     
        public IActionResult GetEmpById([FromRoute]int id)
        {
            var ret  = context.Emps.FirstOrDefault(e=>e.id == id);
            return Ok(ret);
        }
        [HttpGet("{name:alpha}")]

        public IActionResult GetEmpByName(string name)
        {
            var ret = context.Emps.FirstOrDefault(e => e.name == name);
            return Ok(ret);
        }

        [HttpPut("{id}")]
        public IActionResult PutEmp([FromRoute] int id, [FromBody] Emp emp)
        {
            if (ModelState.IsValid)
            {
                var oldEmp = context.Emps.FirstOrDefault(emp=>emp.id == id);
                oldEmp.name = emp.name;
                oldEmp.address = emp.address;
                oldEmp.salary = emp.salary;
                oldEmp.age = emp.age;
                context.SaveChanges();
                return Ok(oldEmp);

            }
             return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
            try
            {
                var emp = context.Emps.FirstOrDefault(e => e.id == id);
                context.Emps.Remove(emp);
                context.SaveChanges();
                return Ok(emp);
            } catch (Exception ex)
            {
                return NotFound(ex);
            }
    
        }
    }
}
