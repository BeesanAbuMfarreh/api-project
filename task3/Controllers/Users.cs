using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task3.Repo;
using task3.Mdels;
namespace task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {

        public Users()
        {

        }
        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return UserRepo.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = UserRepo.Get(id);
            if (user == null)
                return NotFound();
            return user;
        }
        [HttpDelete]

        public ActionResult Delete(int id)
        {
            var user = UserRepo.Get(id);
            if (user == null)
                return NotFound();
            UserRepo.delete(id);
            return Ok();
        }
        [HttpPost]
        public ActionResult Creat(User user)
        {
            UserRepo.add(user);
            return Ok();
        }
        [HttpPut]
      public ActionResult Update(User user)
        {
            var _user = UserRepo.Get(user.Id);
            if(_user == null)
                return NotFound();
            UserRepo.update(user);
            return Ok();
        }
    }

}
