using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Interface;
using DAL.Data;
using Models.Model;
using Microsoft.AspNetCore.Components.Authorization;
//using Microsoft.EntityFrameworkCore;
namespace Webapi.Controllers
{
    [Route("api/[concroller]")]
    [ApiController]
    public class TodosController : Controller
    {
        private readonly ITodo _dbstoreToDo;
        public TodosController(ITodo dbstoreToDo)
        {
            _dbstoreToDo = dbstoreToDo;
        }
      
        [HttpPost]
        [Route("/api/addToDo")]
        public async Task<ActionResult<bool>> addToDo(Todo todo)
        {
            var res= _dbstoreToDo.AddToDo(todo);
            return Ok(res);

        }

        // POST: Todos/Create




        // GET: Todos/Delete/5
        [HttpDelete]
        [Route("/api/deleteTodo")]
        public async Task<ActionResult<bool>> deleteTodo(int id)
        {
            await _dbstoreToDo.DeleteToDo(id);
            return Ok();
        }

        [HttpPut]
        [Route("/api/ChangeTodo")]
        public async Task<ActionResult<bool>> ChangeTodo(Todo todo)
        {
            await _dbstoreToDo.PutToDo(todo);
            return Ok();
        }


        [HttpGet]
        [Route("/api/getalltodos")]
        public async Task<ActionResult<bool>> getalltodos()
        {
          var res=  await _dbstoreToDo.getarrTodoes();
            if (res.Count == 0)
                return BadRequest();
            return Ok(res);
        }

    }
}
