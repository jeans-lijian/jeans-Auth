using Jeans.WebCore.Models;
using Jeans.WebCore.Models.Account;
using Jeans.WebCore.ViewModels;
using Jeans.WebCore.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jeans.WebCore.Controllers
{
    public class UserController : BaseController
    {
        //private readonly IUserService _userService;
        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public IActionResult List()
        {
            Menu();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> List(BaseRequest baseRequest, string nameEmpNo)
        {
            //TableResponse<UserResponse> tableResponse = await _userService.GetUsers(baseRequest.PageIndex, baseRequest.Length, nameEmpNo);

            //var result = new List<UserViewModel>();
            //foreach (var item in tableResponse.Data)
            //{
            //    result.Add(new UserViewModel
            //    {
            //        Id = item.Id,
            //        EmpNo = item.EmpNo,
            //        Name = item.Name,
            //        Card = item.Card,
            //        Sex = item.Sex,
            //        ImgUrl = item.ImgUrl,
            //        Birthday = item.Birthday?.ToString("yyyy-MM-dd"),
            //        Email = item.Email,
            //        Department = item.Department,
            //        Room = item.Room,
            //        Job = item.Job,
            //        JobAddress = item.JobAddress,
            //        JobName = item.JobName,
            //        School = item.School,
            //        Education = item.Education,
            //        InductionDate = item.InductionDate?.ToString("yyyy-MM-dd"),
            //        ResignDate = item.ResignDate?.ToString("yyyy-MM-dd HH:mm:ss"),
            //        MobilePhone = item.MobilePhone,
            //        OfficePhone = item.OfficePhone,
            //        HealthStatus = item.HealthStatus,
            //        Nationality = item.Nationality,
            //        IsUsed = item.IsUsed
            //    });
            //}

            //return Json(new
            //{
            //    baseRequest.Draw,
            //    RecordsTotal = tableResponse.Total,
            //    RecordsFiltered = tableResponse.Total,
            //    Data = result
            //});

            return Json("");
        }

        public IActionResult Add()
        {
            Menu();
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            Menu();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Menu();
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            Menu();

            //UserResponse userResponse = await _userService.GetUserById(id);
            //if (userResponse == null)
            //{
            //    return View(new UserViewModel());
            //}

            //var model = new UserViewModel
            //{
            //    Id = userResponse.Id,
            //    EmpNo = userResponse.EmpNo,
            //    Name = userResponse.Name,
            //    Card = userResponse.Card,
            //    Sex = userResponse.Sex,
            //    ImgUrl = userResponse.ImgUrl,
            //    Birthday = userResponse.Birthday?.ToString("yyyy-MM-dd"),
            //    Email = userResponse.Email,
            //    Department = userResponse.Department,
            //    Room = userResponse.Room,
            //    Job = userResponse.Job,
            //    JobAddress = userResponse.JobAddress,
            //    JobName = userResponse.JobName,
            //    School = userResponse.School,
            //    Education = userResponse.Education,
            //    InductionDate = userResponse.InductionDate?.ToString("yyyy-MM-dd"),
            //    ResignDate = userResponse.ResignDate?.ToString("yyyy-MM-dd HH:mm:ss"),
            //    MobilePhone = userResponse.MobilePhone,
            //    OfficePhone = userResponse.OfficePhone,
            //    HealthStatus = userResponse.HealthStatus,
            //    Nationality = userResponse.Nationality,
            //    IsUsed = userResponse.IsUsed,
            //    CreateDate = userResponse.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"),
            //    ModifyDate = userResponse.ModifyDate.ToString("yyyy-MM-dd HH:mm:ss"),
            //    CreatePerson = userResponse.CreatePerson,
            //    ModifyPerson = userResponse.ModifyPerson
            //};

            //return View(model);

            return View();
        }

        void Menu()
        {
            var menus = new List<MenuViewModel>();

            var entity1 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = Guid.Empty,
                MenuName = "个人中心",
                ControllerName = "Home",
                ActionName = "Index",
                IconClass = "fa-link",
                Sort = 1
            };
            menus.Add(entity1);

            var entity2 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = Guid.Empty,
                MenuName = "基础信息",
                ControllerName = "Home",
                ActionName = "BaseInfo",
                IconClass = "fa-link",
                Sort = 2
            };
            menus.Add(entity2);

            var entity3 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = Guid.Empty,
                MenuName = "资质管理",
                IconClass = "fa-link",
                Sort = 3
            };
            entity3.MenuViewModels = new List<MenuViewModel>
            {
                new MenuViewModel{
                    Id=Guid.NewGuid(),
                    ParentId=entity3.Id,
                    MenuName="告警信息",
                    ControllerName="Home",
                    ActionName="Test1",
                    IconClass = "fa-circle-o",
                    Sort=1
                },
                new MenuViewModel{
                    Id=Guid.NewGuid(),
                    ParentId=entity3.Id,
                    MenuName="培训管理",
                    ControllerName="Home",
                    ActionName="Test2",
                    IconClass = "fa-circle-o",
                    Sort=2
                }
            };
            menus.Add(entity3);

            var entity4 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = Guid.Empty,
                MenuName = "后台管理",
                IconClass = "fa-link",
                Sort = 4
            };

            var entity4_2 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = entity4.Id,
                MenuName = "用户管理",
                ControllerName = "User",
                ActionName = "List",
                IconClass = "fa-circle-o",
                Sort = 1
            };

            var entity4_1 = new MenuViewModel
            {
                Id = Guid.NewGuid(),
                ParentId = entity4.Id,
                MenuName = "权限管理",
                IconClass = "fa-circle-o",
                Sort = 1
            };

            entity4_1.MenuViewModels = new List<MenuViewModel>
            {
                new MenuViewModel{
                    Id=Guid.NewGuid(),
                    ParentId=entity4_1.Id,
                    MenuName="角色管理",
                    ControllerName="Home",
                    ActionName="Role",
                    IconClass = "fa-circle-o",
                    Sort=2
                }
            };

            entity4.MenuViewModels = new List<MenuViewModel>
            {
                entity4_2,
                entity4_1
            };
            menus.Add(entity4);

            ViewData["Menu"] = menus;
        }
    }
}