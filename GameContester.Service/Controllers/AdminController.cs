using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using GameContester.Contracts.Services;
using GameContester.Domain.Entities;
using GameContester.Service.Models;

namespace GameContester.Service.Controllers
{
    [RoutePrefix("api/Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private IUserService userService;

        public AdminController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("GetBannedUsers")]

        public IHttpActionResult GetBannedUsers()
        {
            List<User> users = userService.GetAll().Where(x => x.IsBanned).ToList();
            Mapper.CreateMap<User, UserModel>();
            List<UserModel> model = new List<UserModel>();
            foreach (var user in users)
            {
                model.Add(Mapper.Map<UserModel>(user));
            }
            return Ok(model);
        }

        [HttpPost]
        [Route("UnbanUsers")]
        public IHttpActionResult UnbanUsers(List<string> userIds)
        {
            userService.UnbanUsers(userIds);
            return Ok();
        }

        [HttpGet]
        [Route("BanUser")]
        public IHttpActionResult BanUser(string userId)
        {
            userService.BanUser(userId);
            return Ok();
        }
    }
}
