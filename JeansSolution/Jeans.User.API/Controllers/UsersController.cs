using Jeans.User.API.Controllers.MapExtensions;
using Jeans.User.API.Models;
using Jeans.User.API.Models.Account;
using Jeans.User.Core.Domain.Account;
using Jeans.User.Services.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jeans.User.API.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public IHttpActionResult Get(int id)
        {
            Users entity = _userService.GetUser(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [Route("getAll")]
        [HttpGet]
        public IHttpActionResult Get([FromUri]PageRequest body, string nameOrEmpNo)
        {
            int total;
            List<Users> users = _userService.GetUsers(body.PageIndex, body.PageSize, out total, nameOrEmpNo);

            return Ok(new
            {
                Data = users.ToList(),
                Total = total
            });
        }

        public IHttpActionResult Post(UserRequest model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return BadRequest(ModelState);
            }

            Users entity = model.ToEntity();
            _userService.AddUser(entity);

            return Created("/api/users/" + entity.Id, entity);
        }

        public IHttpActionResult Put(int id, UserRequest model)
        {
            if (!ModelState.IsValid || id != model.Id)
            {
                return BadRequest(ModelState);
            }

            Users entity = _userService.GetUser(id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Birthday = model.Birthday;
            entity.Card = model.Card;
            entity.Department = model.Department;
            entity.Education = model.Education;
            entity.Email = model.Email;
            entity.HealthStatus = model.HealthStatus;
            entity.InductionDate = model.InductionDate;
            entity.ResignDate = model.ResignDate;
            entity.Room = model.Room;
            entity.School = model.School;
            entity.Sex = model.Sex;
            entity.IsUsed = model.IsUsed;
            entity.Job = model.Job;
            entity.JobAddress = model.JobAddress;
            entity.JobName = model.JobName;
            entity.MobilePhone = model.MobilePhone;
            entity.Nationality = model.Nationality;
            entity.OfficePhone = model.OfficePhone;
            entity.ModifyPerson = model.EmpNo;
            entity.ModifyDate = DateTime.Now;

            _userService.UpdateUser(entity);

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            Users entity = _userService.GetUser(id);
            if (entity == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(entity);

            return Ok(entity);
        }
    }
}