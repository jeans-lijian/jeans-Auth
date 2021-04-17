using Jeans.BaseData.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Jeans.BaseData.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [ControllerName("menu")]
    [Route("api/basedata/[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpGet("getlist")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetList()
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
                MenuName = "Demo管理",
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
                    MenuName="用户管理",
                    ControllerName="User",
                    ActionName="List",
                    IconClass = "fa-circle-o",
                    Sort=1
                },
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
                entity4_1
            };
            menus.Add(entity4);

            return Ok(menus);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "test")]
        public IActionResult Get(int id)
        {
            return Ok("success");
        }
    }
}
