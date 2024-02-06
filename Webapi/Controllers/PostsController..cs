using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Interface;
using DAL.Data;
using Models.Model;
using Microsoft.AspNetCore.Components.Authorization;

namespace Webapi.Controllers
{
    [Route("api/[concroller]")]
    [ApiController]
    public class PostsController : Controller
    {

        private readonly IPost _dbstoreToDo;
        public PostsController(IPost dbstoreToDo)
        {
            _dbstoreToDo = dbstoreToDo;
        }



        [HttpPost]
        [Route("/api/addPost")]
        public async Task<ActionResult<bool>> addPost(Post post)
        {
            var res = _dbstoreToDo.AddPost(post);
            return Ok(res);

        }

        [HttpDelete]
        [Route("/api/deletePost")]
        public async Task<ActionResult<bool>> deletePost(int id)
        {
            await _dbstoreToDo.DeletePost(id);
            return Ok();
        }

        [HttpPut]
        [Route("/api/ChangePost")]
        public async Task<ActionResult<bool>> ChangePost(Post post)
        {
            await _dbstoreToDo.PutPost(post);
            return Ok();
        }


        [HttpGet]
        [Route("/api/getallPosts")]
        public async Task<ActionResult<bool>> getallPosts()
        {
          var res=  await _dbstoreToDo.getarrPostes();
            if (res.Count == 0)
                return BadRequest();
            return Ok(res);
        }

    }
}

