using BlogApi.Models;
using BlogApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogApi.Controllers
{
    public class UserController : ApiController
    {
        UserRepository ur = new UserRepository();
        public IHttpActionResult Get()
        {
            return Ok(ur.GetAllData());  
        }
        public IHttpActionResult Post(User user)
        {
            ur.Insert(user);
            return Created("api/Users/"+user.UserId,user);  
        }
    }
}
