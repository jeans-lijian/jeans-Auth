﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jeans.WebCore.Models;

namespace Jeans.WebCore.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
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

            ViewData["Menu"] = menus;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
